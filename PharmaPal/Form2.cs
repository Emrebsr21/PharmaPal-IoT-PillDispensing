using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace PharmaPal
{
    public partial class Form2 : Form
    {
        private static readonly HttpClient client = new HttpClient(new HttpClientHandler
        {
            UseCookies = false,
            AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
        });
        private string FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login_info.txt");
        private string username;
        private static float lastTemperature = float.NaN;
        private static float lastHumidity = float.NaN;
        private static float lastHeatIndex = float.NaN;

        public Form2()
        {
            InitializeComponent();
            panelPasswrodChange.Visible = false;
            panelIndicator.Visible = false;
            _ = FetchSensorData(); // Fetch data immediately upon initialization
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; // Set interval to 5 seconds
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            string[] credentials = File.ReadAllLines(FileName);
            foreach (string line in credentials)
            {
                string[] parts = line.Split('-');
                username = parts[0].Trim();
                break;
            }
            labelUsername.Text = username;

            // Load the saved pill names
            LoadPillNames();
        }

        private void buttonScheduleWizard_Click(object sender, EventArgs e)
        {
            ScheduleWizardForm wizardForm = new ScheduleWizardForm();
            wizardForm.Show();
        }

        private async void btnInstantAccess_Click(object sender, EventArgs e)
        {
            await TriggerInstantAccess();
        }

        private async Task TriggerInstantAccess()
        {
            using (var client = new HttpClient(new HttpClientHandler
            {
                UseCookies = false,
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
            }))
            {
                try
                {
                    // Define the URL of the ESP32 web server
                    string url = "http://pharmapal.local/trigger";

                    // Clear previous headers
                    client.DefaultRequestHeaders.Clear();

                    // Send a GET request to the trigger endpoint
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Ensure a successful response
                    response.EnsureSuccessStatusCode();

                    // Read and display the response content
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Response from ESP32: {responseBody}", "Instant Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Request error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            panelPasswrodChange.Visible = true;
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void buttonCancelUpdate_Click(object sender, EventArgs e)
        {
            panelPasswrodChange.Visible = false;
            panelPillNames.Visible = false;
        }

        private void buttonUpdatePsswd_Click(object sender, EventArgs e)
        {
            string currentPassword = textBoxCurrentPsswd.Text;
            string newPassword = textBoxNewPsswd.Text;
            string confirmPassword = textBoxRetypePsswd.Text;

            string[] credentials = File.ReadAllLines(FileName);

            foreach (string line in credentials)
            {
                string[] parts = line.Split('-');
                string username = parts[0].Trim();
                string savedPassword = parts[1].Trim();

                if (currentPassword == savedPassword)
                {
                    if (newPassword == confirmPassword)
                    {
                        savedPassword = newPassword;

                        string tempFileName = Path.GetTempFileName();

                        using (StreamWriter writer = new StreamWriter(tempFileName))
                        {
                            writer.WriteLine($"{username} - {savedPassword}");
                            foreach (string credential in credentials)
                            {
                                if (credential != line)
                                {
                                    writer.WriteLine(credential);
                                }
                            }
                        }

                        File.Delete(FileName);
                        File.Move(tempFileName, FileName);

                        MessageBox.Show("Password changed successfully.");
                        panelPasswrodChange.Visible = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("New passwords don't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            MessageBox.Show("Current password is wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            await FetchSensorData();
        }

        private async Task FetchSensorData()
        {
            try
            {
                string url = "http://pharmapal.local/sensor"; // Use the static IP address or mDNS name

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseBody))
                {
                    JsonElement root = doc.RootElement;
                    float temperature = root.GetProperty("temperature").GetSingle();
                    float humidity = root.GetProperty("humidity").GetSingle();
                    float heatIndex = root.GetProperty("heatIndex").GetSingle();

                    lastTemperature = temperature;
                    lastHumidity = humidity;
                    lastHeatIndex = heatIndex;

                    txtTemperature.Text = $"{temperature} °C";
                    txtHumidity.Text = $"{humidity} %";
                    txtHeatIndex.Text = $"{heatIndex} °C";

                    UpdateHeatIndexColor(heatIndex);
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show($"Request error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UseLastSuccessfulValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UseLastSuccessfulValues();
            }
        }

        private void UseLastSuccessfulValues()
        {
            if (!float.IsNaN(lastTemperature) && !float.IsNaN(lastHumidity) && !float.IsNaN(lastHeatIndex))
            {
                txtTemperature.Text = $"{lastTemperature} °C (last)";
                txtHumidity.Text = $"{lastHumidity} % (last)";
                txtHeatIndex.Text = $"{lastHeatIndex} °C (last)";
            }
        }

        private void UpdateHeatIndexColor(float heatIndex)
        {
            if (heatIndex < 15.6)
            {
                lblHeatIndexColor.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (heatIndex >= 15.6 && heatIndex < 18.3)
            {
                lblHeatIndexColor.BackColor = System.Drawing.Color.Blue;
            }
            else if (heatIndex >= 18.3 && heatIndex < 23.9)
            {
                lblHeatIndexColor.BackColor = System.Drawing.Color.Green;
            }
            else if (heatIndex >= 23.9 && heatIndex < 26.7)
            {
                lblHeatIndexColor.BackColor = System.Drawing.Color.Yellow;
            }
            else if (heatIndex >= 26.7 && heatIndex < 29.4)
            {
                lblHeatIndexColor.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                lblHeatIndexColor.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btnHideParameter_Click(object sender, EventArgs e)
        {
            panelIndicator.Visible = false;
        }

        private void lblHeatIndexColor_Click(object sender, EventArgs e)
        {
            panelIndicator.Visible = true;
        }

        private void buttonResetPills_Click(object sender, EventArgs e)
        {
            panelPillNames.Visible = true;
        }

        private void buttonSaveNames_Click(object sender, EventArgs e)
        {
            panelPillNames.Visible = false;

            string pillName1 = InputC1.Text;
            string pillName2 = InputC2.Text;
            string pillName3 = InputC3.Text;

            textBoxC1.Text = pillName1;
            textBoxC2.Text = pillName2;
            textBoxC3.Text = pillName3;

            // Create the directory if it doesn't exist
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "savedPills");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Define the file path
            string filePath = Path.Combine(directoryPath, "savedPills.txt");

            // Delete the existing file if it exists
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            // Write the new content to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"{pillName1} - {pillName2} - {pillName3}");
            }
        }

        private void LoadPillNames()
        {
            // Define the file path
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "savedPills");
            string filePath = Path.Combine(directoryPath, "savedPills.txt");

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the content of the file
                string content = File.ReadAllText(filePath);
                string[] parts = content.Split('-');

                // Ensure there are exactly 3 parts
                if (parts.Length == 3)
                {
                    textBoxC1.Text = parts[0].Trim();
                    textBoxC2.Text = parts[1].Trim();
                    textBoxC3.Text = parts[2].Trim();
                }
            }
        }
    }
}
