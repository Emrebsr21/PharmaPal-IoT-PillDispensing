using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaPal
{
    public partial class ScheduleWizardForm : Form
    {
        private int scheduleCount = 0;
        private static readonly HttpClient client = new HttpClient();
        private List<string> pillNames;

        public ScheduleWizardForm()
        {
            InitializeComponent();
            LoadPillNames();
            AddScheduleControls();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            AddScheduleControls();
        }

        private void btnScheduleTasks_Click(object sender, EventArgs e)
        {
            _ = ScheduleTasksAsync();
        }

        private void btnDisplayCurrentSchedule_Click(object sender, EventArgs e)
        {
            DisplayCurrentSchedule();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void LoadPillNames()
        {
            pillNames = new List<string> { "Compartment 1", "Compartment 2", "Compartment 3" }; // Default names

            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "savedPills");
            string filePath = Path.Combine(directoryPath, "savedPills.txt");

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                string[] parts = content.Split('-');

                for (int i = 0; i < parts.Length; i++)
                {
                    string pillName = parts[i].Trim();
                    if (!string.IsNullOrEmpty(pillName))
                    {
                        pillNames[i] = pillName;
                    }
                }
            }
        }

        private void AddScheduleControls()
        {
            if (scheduleCount >= 12) return;

            // Create a new panel to hold each schedule set
            Panel schedulePanel = new Panel
            {
                Width = panelScroll.Width - 25,
                Height = 90, // Increased height to accommodate the new labels
                Margin = new Padding(0, 0, 0, 10),
                Name = $"schedulePanel{scheduleCount}"
            };

            // Schedule label
            Label label = new Label
            {
                Text = $"Schedule {scheduleCount + 1}",
                Top = 0,
                Left = 0,
                Width = 150,
                Font = new Font("Book Antiqua", 9),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Compartment dropdown
            ComboBox compartmentDropdown = new ComboBox
            {
                Top = 20,
                Left = 0,
                Width = 150,
                Font = new Font("Book Antiqua", 10),
                Name = $"compartment{scheduleCount}",
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            compartmentDropdown.Items.AddRange(pillNames.ToArray());

            // Hour label
            Label hourLabel = new Label
            {
                Text = "Hour",
                Top = 0,
                Left = 160,
                Width = 60,
                Font = new Font("Book Antiqua", 9),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Minute label
            Label minuteLabel = new Label
            {
                Text = "Minute",
                Top = 0,
                Left = 230,
                Width = 60,
                Font = new Font("Book Antiqua", 9),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Hour dropdown
            NumericUpDown hourDropdown = new NumericUpDown
            {
                Top = 20,
                Left = 160,
                Width = 60,
                Minimum = 0,
                Maximum = 23,
                Font = new Font("Book Antiqua", 10),
                Name = $"hour{scheduleCount}"
            };

            // Minute dropdown
            NumericUpDown minuteDropdown = new NumericUpDown
            {
                Top = 20,
                Left = 230,
                Width = 60,
                Minimum = 0,
                Maximum = 59,
                Font = new Font("Book Antiqua", 10),
                Name = $"minute{scheduleCount}"
            };

            schedulePanel.Controls.Add(label);
            schedulePanel.Controls.Add(compartmentDropdown);
            schedulePanel.Controls.Add(hourLabel);
            schedulePanel.Controls.Add(minuteLabel);
            schedulePanel.Controls.Add(hourDropdown);
            schedulePanel.Controls.Add(minuteDropdown);

            // Add a horizontal line
            Label horizontalLine = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                Top = 70,
                Left = 0,
                Width = schedulePanel.Width,
                Height = 2
            };
            schedulePanel.Controls.Add(horizontalLine);

            panelScroll.Controls.Add(schedulePanel);

            scheduleCount++;
        }

        private async Task ScheduleTasksAsync()
        {
            var scheduleData = new Dictionary<string, string>();
            var scheduleLines = new List<string>();

            for (int i = 0; i < scheduleCount; i++)
            {
                try
                {
                    var compartmentControl = panelScroll.Controls.Find($"compartment{i}", true);
                    var hourControl = panelScroll.Controls.Find($"hour{i}", true);
                    var minuteControl = panelScroll.Controls.Find($"minute{i}", true);

                    if (compartmentControl.Length == 0 || hourControl.Length == 0 || minuteControl.Length == 0)
                    {
                        throw new Exception($"Unable to find controls for schedule {i + 1}.");
                    }

                    var compartment = (ComboBox)compartmentControl[0];
                    var hour = (NumericUpDown)hourControl[0];
                    var minute = (NumericUpDown)minuteControl[0];

                    if (compartment.SelectedItem == null)
                    {
                        throw new Exception($"Please select a compartment for schedule {i + 1}.");
                    }

                    // Debugging information
                    Console.WriteLine($"Schedule {i + 1}: Compartment {compartment.SelectedItem}, Hour {hour.Value}, Minute {minute.Value}");

                    // Corrected value to match HTML form values
                    int compartmentValue = compartment.SelectedIndex + 15; // Compartment 1 is 15, Compartment 2 is 16, Compartment 3 is 17

                    scheduleData.Add($"compartment{i}", compartmentValue.ToString());
                    scheduleData.Add($"hour{i}", hour.Value.ToString());
                    scheduleData.Add($"minute{i}", minute.Value.ToString("00"));

                    scheduleLines.Add($"{pillNames[compartment.SelectedIndex]} - {hour.Value:00} - {minute.Value:00}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Write to currentSchedule.txt
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "currentSchedule.txt");
            File.WriteAllLines(filePath, scheduleLines);

            var content = new FormUrlEncodedContent(scheduleData);
            try
            {
                HttpResponseMessage response = await client.PostAsync("http://pharmapal.local/schedule", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Response from server: {responseBody}", "Schedule Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show($"Request error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCurrentSchedule()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "currentSchedule.txt");
            if (!File.Exists(filePath))
            {
                MessageBox.Show("No current schedule found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] scheduleLines = File.ReadAllLines(filePath);
            ClearExistingControls();

            foreach (string line in scheduleLines)
            {
                string[] parts = line.Split('-');
                if (parts.Length == 3)
                {
                    AddScheduleControls();
                    var compartmentControl = panelScroll.Controls.Find($"compartment{scheduleCount - 1}", true);
                    var hourControl = panelScroll.Controls.Find($"hour{scheduleCount - 1}", true);
                    var minuteControl = panelScroll.Controls.Find($"minute{scheduleCount - 1}", true);

                    if (compartmentControl.Length > 0 && hourControl.Length > 0 && minuteControl.Length > 0)
                    {
                        var compartment = (ComboBox)compartmentControl[0];
                        var hour = (NumericUpDown)hourControl[0];
                        var minute = (NumericUpDown)minuteControl[0];

                        compartment.SelectedIndex = pillNames.IndexOf(parts[0].Trim());
                        hour.Value = int.Parse(parts[1].Trim());
                        minute.Value = int.Parse(parts[2].Trim());
                    }
                }
            }
        }

        private void ClearExistingControls()
        {
            for (int i = panelScroll.Controls.Count - 1; i >= 0; i--)
            {
                var control = panelScroll.Controls[i];
                if (control is Panel panel && panel.Name.StartsWith("schedulePanel"))
                {
                    panelScroll.Controls.Remove(panel);
                }
            }
            scheduleCount = 0;
        }

        private void ClearFields()
        {
            ClearExistingControls();
            AddScheduleControls();
        }
    }
}
