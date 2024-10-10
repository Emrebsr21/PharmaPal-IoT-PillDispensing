using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaPal
{
    public partial class Form1 : Form
    {
        private int attempts = 0;
        private string FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login_info.txt");
        public Form1()
        {
            InitializeComponent();
            textUserLogin.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string enteredPin = textUserPsswd.Text;
            string enteredUsername = textUserLogin.Text;

            string[] credentials = File.ReadAllLines(FileName);
            foreach (string line in credentials)
            {
                string[] parts = line.Split('-');
                string username = parts[0].Trim();
                string pin = parts[1].Trim();


                if (textUserPsswd.Text == pin && textUserLogin.Text == username)
                {
                    attempts = 0;
                    Hide();
                    new Form2().Show();
                }

                else
                {
                    attempts++;
                    if (attempts >= 3)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect pin. Attempts remaining: " + (3 - attempts));
                        textUserLogin.Clear();
                        textUserPsswd.Clear();
                        textUserLogin.Focus();
                    }
                }
            }
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            textUserLogin.Clear();
            textUserPsswd.Clear();
            textUserLogin.Focus();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
