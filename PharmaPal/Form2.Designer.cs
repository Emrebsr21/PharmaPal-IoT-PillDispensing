namespace PharmaPal
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPasswrodChange = new System.Windows.Forms.Panel();
            this.buttonCancelUpdate = new System.Windows.Forms.Button();
            this.buttonUpdatePsswd = new System.Windows.Forms.Button();
            this.labelNewPsswd = new System.Windows.Forms.Label();
            this.labelRetypePsswd = new System.Windows.Forms.Label();
            this.labelCurrentPsswd = new System.Windows.Forms.Label();
            this.textBoxNewPsswd = new System.Windows.Forms.TextBox();
            this.textBoxRetypePsswd = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPsswd = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.iconUser = new System.Windows.Forms.PictureBox();
            this.btnInstantAccess = new System.Windows.Forms.Button();
            this.buttonScheduleWizard = new System.Windows.Forms.Button();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtHeatIndex = new System.Windows.Forms.TextBox();
            this.lblHeatIndexColor = new System.Windows.Forms.Label();
            this.labeltemp = new System.Windows.Forms.Label();
            this.labelhumid = new System.Windows.Forms.Label();
            this.labelHeatIndex = new System.Windows.Forms.Label();
            this.panelIndicator = new System.Windows.Forms.Panel();
            this.labelind6 = new System.Windows.Forms.Label();
            this.labelind5 = new System.Windows.Forms.Label();
            this.labelind4 = new System.Windows.Forms.Label();
            this.labelind3 = new System.Windows.Forms.Label();
            this.labelind2 = new System.Windows.Forms.Label();
            this.labelind1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHideParameter = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonResetPills = new System.Windows.Forms.Button();
            this.panelPillNames = new System.Windows.Forms.Panel();
            this.buttonCancelNameChange = new System.Windows.Forms.Button();
            this.buttonSaveNames = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputC2 = new System.Windows.Forms.TextBox();
            this.InputC3 = new System.Windows.Forms.TextBox();
            this.InputC1 = new System.Windows.Forms.TextBox();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.textBoxC3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelPasswrodChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.panelIndicator.SuspendLayout();
            this.panelPillNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonChangePassword.FlatAppearance.BorderSize = 0;
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonChangePassword.Location = new System.Drawing.Point(13, 89);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(216, 35);
            this.buttonChangePassword.TabIndex = 16;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonSignOut.FlatAppearance.BorderSize = 0;
            this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignOut.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignOut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSignOut.Location = new System.Drawing.Point(13, 130);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(216, 35);
            this.buttonSignOut.TabIndex = 17;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.panelPasswrodChange);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.iconUser);
            this.panel1.Controls.Add(this.buttonChangePassword);
            this.panel1.Controls.Add(this.buttonSignOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(633, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 451);
            this.panel1.TabIndex = 18;
            // 
            // panelPasswrodChange
            // 
            this.panelPasswrodChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPasswrodChange.Controls.Add(this.buttonCancelUpdate);
            this.panelPasswrodChange.Controls.Add(this.buttonUpdatePsswd);
            this.panelPasswrodChange.Controls.Add(this.labelNewPsswd);
            this.panelPasswrodChange.Controls.Add(this.labelRetypePsswd);
            this.panelPasswrodChange.Controls.Add(this.labelCurrentPsswd);
            this.panelPasswrodChange.Controls.Add(this.textBoxNewPsswd);
            this.panelPasswrodChange.Controls.Add(this.textBoxRetypePsswd);
            this.panelPasswrodChange.Controls.Add(this.textBoxCurrentPsswd);
            this.panelPasswrodChange.Location = new System.Drawing.Point(13, 183);
            this.panelPasswrodChange.Name = "panelPasswrodChange";
            this.panelPasswrodChange.Size = new System.Drawing.Size(225, 243);
            this.panelPasswrodChange.TabIndex = 19;
            this.panelPasswrodChange.Visible = false;
            // 
            // buttonCancelUpdate
            // 
            this.buttonCancelUpdate.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelUpdate.ForeColor = System.Drawing.Color.Teal;
            this.buttonCancelUpdate.Location = new System.Drawing.Point(116, 205);
            this.buttonCancelUpdate.Name = "buttonCancelUpdate";
            this.buttonCancelUpdate.Size = new System.Drawing.Size(81, 30);
            this.buttonCancelUpdate.TabIndex = 7;
            this.buttonCancelUpdate.Text = "Cancel";
            this.buttonCancelUpdate.UseVisualStyleBackColor = true;
            this.buttonCancelUpdate.Click += new System.EventHandler(this.buttonCancelUpdate_Click);
            // 
            // buttonUpdatePsswd
            // 
            this.buttonUpdatePsswd.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePsswd.ForeColor = System.Drawing.Color.Teal;
            this.buttonUpdatePsswd.Location = new System.Drawing.Point(15, 205);
            this.buttonUpdatePsswd.Name = "buttonUpdatePsswd";
            this.buttonUpdatePsswd.Size = new System.Drawing.Size(95, 30);
            this.buttonUpdatePsswd.TabIndex = 6;
            this.buttonUpdatePsswd.Text = "Update PSSWD";
            this.buttonUpdatePsswd.UseVisualStyleBackColor = true;
            this.buttonUpdatePsswd.Click += new System.EventHandler(this.buttonUpdatePsswd_Click);
            // 
            // labelNewPsswd
            // 
            this.labelNewPsswd.AutoSize = true;
            this.labelNewPsswd.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPsswd.ForeColor = System.Drawing.Color.Teal;
            this.labelNewPsswd.Location = new System.Drawing.Point(13, 72);
            this.labelNewPsswd.Name = "labelNewPsswd";
            this.labelNewPsswd.Size = new System.Drawing.Size(97, 17);
            this.labelNewPsswd.TabIndex = 5;
            this.labelNewPsswd.Text = "New Password";
            // 
            // labelRetypePsswd
            // 
            this.labelRetypePsswd.AutoSize = true;
            this.labelRetypePsswd.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetypePsswd.ForeColor = System.Drawing.Color.Teal;
            this.labelRetypePsswd.Location = new System.Drawing.Point(13, 136);
            this.labelRetypePsswd.Name = "labelRetypePsswd";
            this.labelRetypePsswd.Size = new System.Drawing.Size(117, 17);
            this.labelRetypePsswd.TabIndex = 4;
            this.labelRetypePsswd.Text = "Confirm Password";
            // 
            // labelCurrentPsswd
            // 
            this.labelCurrentPsswd.AutoSize = true;
            this.labelCurrentPsswd.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPsswd.ForeColor = System.Drawing.Color.Teal;
            this.labelCurrentPsswd.Location = new System.Drawing.Point(13, 9);
            this.labelCurrentPsswd.Name = "labelCurrentPsswd";
            this.labelCurrentPsswd.Size = new System.Drawing.Size(114, 17);
            this.labelCurrentPsswd.TabIndex = 3;
            this.labelCurrentPsswd.Text = "Current Password";
            // 
            // textBoxNewPsswd
            // 
            this.textBoxNewPsswd.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPsswd.Location = new System.Drawing.Point(16, 91);
            this.textBoxNewPsswd.Multiline = true;
            this.textBoxNewPsswd.Name = "textBoxNewPsswd";
            this.textBoxNewPsswd.Size = new System.Drawing.Size(182, 29);
            this.textBoxNewPsswd.TabIndex = 2;
            // 
            // textBoxRetypePsswd
            // 
            this.textBoxRetypePsswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRetypePsswd.Location = new System.Drawing.Point(16, 155);
            this.textBoxRetypePsswd.Multiline = true;
            this.textBoxRetypePsswd.Name = "textBoxRetypePsswd";
            this.textBoxRetypePsswd.Size = new System.Drawing.Size(182, 29);
            this.textBoxRetypePsswd.TabIndex = 1;
            // 
            // textBoxCurrentPsswd
            // 
            this.textBoxCurrentPsswd.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPsswd.Location = new System.Drawing.Point(16, 28);
            this.textBoxCurrentPsswd.Multiline = true;
            this.textBoxCurrentPsswd.Name = "textBoxCurrentPsswd";
            this.textBoxCurrentPsswd.Size = new System.Drawing.Size(182, 29);
            this.textBoxCurrentPsswd.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelUsername.Location = new System.Drawing.Point(77, 62);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(103, 24);
            this.labelUsername.TabIndex = 19;
            this.labelUsername.Text = "Username";
            // 
            // iconUser
            // 
            this.iconUser.Image = ((System.Drawing.Image)(resources.GetObject("iconUser.Image")));
            this.iconUser.Location = new System.Drawing.Point(90, 3);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(64, 56);
            this.iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconUser.TabIndex = 18;
            this.iconUser.TabStop = false;
            // 
            // btnInstantAccess
            // 
            this.btnInstantAccess.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstantAccess.Location = new System.Drawing.Point(12, 18);
            this.btnInstantAccess.Name = "btnInstantAccess";
            this.btnInstantAccess.Size = new System.Drawing.Size(152, 154);
            this.btnInstantAccess.TabIndex = 19;
            this.btnInstantAccess.Text = "Instant Access Button  Compartmnet 4";
            this.btnInstantAccess.UseVisualStyleBackColor = true;
            this.btnInstantAccess.Click += new System.EventHandler(this.btnInstantAccess_Click);
            // 
            // buttonScheduleWizard
            // 
            this.buttonScheduleWizard.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleWizard.Location = new System.Drawing.Point(373, 134);
            this.buttonScheduleWizard.Name = "buttonScheduleWizard";
            this.buttonScheduleWizard.Size = new System.Drawing.Size(174, 54);
            this.buttonScheduleWizard.TabIndex = 20;
            this.buttonScheduleWizard.Text = "Schedule Wizard";
            this.buttonScheduleWizard.UseVisualStyleBackColor = true;
            this.buttonScheduleWizard.Click += new System.EventHandler(this.buttonScheduleWizard_Click);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Enabled = false;
            this.txtTemperature.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(116, 212);
            this.txtTemperature.Multiline = true;
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(80, 33);
            this.txtTemperature.TabIndex = 21;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Enabled = false;
            this.txtHumidity.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHumidity.Location = new System.Drawing.Point(116, 251);
            this.txtHumidity.Multiline = true;
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(80, 33);
            this.txtHumidity.TabIndex = 22;
            // 
            // txtHeatIndex
            // 
            this.txtHeatIndex.Enabled = false;
            this.txtHeatIndex.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeatIndex.Location = new System.Drawing.Point(116, 291);
            this.txtHeatIndex.Multiline = true;
            this.txtHeatIndex.Name = "txtHeatIndex";
            this.txtHeatIndex.Size = new System.Drawing.Size(80, 33);
            this.txtHeatIndex.TabIndex = 23;
            // 
            // lblHeatIndexColor
            // 
            this.lblHeatIndexColor.AutoSize = true;
            this.lblHeatIndexColor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatIndexColor.Location = new System.Drawing.Point(11, 359);
            this.lblHeatIndexColor.Name = "lblHeatIndexColor";
            this.lblHeatIndexColor.Size = new System.Drawing.Size(209, 24);
            this.lblHeatIndexColor.TabIndex = 24;
            this.lblHeatIndexColor.Text = "Heat Index Parameter";
            this.lblHeatIndexColor.Click += new System.EventHandler(this.lblHeatIndexColor_Click);
            // 
            // labeltemp
            // 
            this.labeltemp.AutoSize = true;
            this.labeltemp.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltemp.Location = new System.Drawing.Point(11, 217);
            this.labeltemp.Name = "labeltemp";
            this.labeltemp.Size = new System.Drawing.Size(99, 22);
            this.labeltemp.TabIndex = 25;
            this.labeltemp.Text = "Tempreture";
            // 
            // labelhumid
            // 
            this.labelhumid.AutoSize = true;
            this.labelhumid.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhumid.Location = new System.Drawing.Point(11, 262);
            this.labelhumid.Name = "labelhumid";
            this.labelhumid.Size = new System.Drawing.Size(84, 22);
            this.labelhumid.TabIndex = 26;
            this.labelhumid.Text = "Humidity";
            // 
            // labelHeatIndex
            // 
            this.labelHeatIndex.AutoSize = true;
            this.labelHeatIndex.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeatIndex.Location = new System.Drawing.Point(11, 302);
            this.labelHeatIndex.Name = "labelHeatIndex";
            this.labelHeatIndex.Size = new System.Drawing.Size(94, 22);
            this.labelHeatIndex.TabIndex = 27;
            this.labelHeatIndex.Text = "Heat Index";
            // 
            // panelIndicator
            // 
            this.panelIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelIndicator.Controls.Add(this.labelind6);
            this.panelIndicator.Controls.Add(this.labelind5);
            this.panelIndicator.Controls.Add(this.labelind4);
            this.panelIndicator.Controls.Add(this.labelind3);
            this.panelIndicator.Controls.Add(this.labelind2);
            this.panelIndicator.Controls.Add(this.labelind1);
            this.panelIndicator.Controls.Add(this.textBox6);
            this.panelIndicator.Controls.Add(this.textBox5);
            this.panelIndicator.Controls.Add(this.textBox4);
            this.panelIndicator.Controls.Add(this.textBox2);
            this.panelIndicator.Controls.Add(this.textBox1);
            this.panelIndicator.Controls.Add(this.btnHideParameter);
            this.panelIndicator.Controls.Add(this.textBox3);
            this.panelIndicator.Location = new System.Drawing.Point(246, 280);
            this.panelIndicator.Name = "panelIndicator";
            this.panelIndicator.Size = new System.Drawing.Size(355, 159);
            this.panelIndicator.TabIndex = 20;
            this.panelIndicator.Visible = false;
            // 
            // labelind6
            // 
            this.labelind6.AutoSize = true;
            this.labelind6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelind6.ForeColor = System.Drawing.Color.Teal;
            this.labelind6.Location = new System.Drawing.Point(237, 85);
            this.labelind6.Name = "labelind6";
            this.labelind6.Size = new System.Drawing.Size(71, 20);
            this.labelind6.TabIndex = 18;
            this.labelind6.Text = "29.4 < C°";
            // 
            // labelind5
            // 
            this.labelind5.AutoSize = true;
            this.labelind5.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelind5.ForeColor = System.Drawing.Color.Teal;
            this.labelind5.Location = new System.Drawing.Point(235, 46);
            this.labelind5.Name = "labelind5";
            this.labelind5.Size = new System.Drawing.Size(99, 20);
            this.labelind5.TabIndex = 17;
            this.labelind5.Text = "26.7 - 29.4 C°";
            // 
            // labelind4
            // 
            this.labelind4.AutoSize = true;
            this.labelind4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelind4.ForeColor = System.Drawing.Color.Teal;
            this.labelind4.Location = new System.Drawing.Point(237, 11);
            this.labelind4.Name = "labelind4";
            this.labelind4.Size = new System.Drawing.Size(99, 20);
            this.labelind4.TabIndex = 16;
            this.labelind4.Text = "23.9 - 26.7 C°";
            // 
            // labelind3
            // 
            this.labelind3.AutoSize = true;
            this.labelind3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelind3.ForeColor = System.Drawing.Color.Teal;
            this.labelind3.Location = new System.Drawing.Point(62, 87);
            this.labelind3.Name = "labelind3";
            this.labelind3.Size = new System.Drawing.Size(99, 20);
            this.labelind3.TabIndex = 15;
            this.labelind3.Text = "18.3 - 23.9 C°";
            // 
            // labelind2
            // 
            this.labelind2.AutoSize = true;
            this.labelind2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelind2.ForeColor = System.Drawing.Color.Teal;
            this.labelind2.Location = new System.Drawing.Point(62, 49);
            this.labelind2.Name = "labelind2";
            this.labelind2.Size = new System.Drawing.Size(99, 20);
            this.labelind2.TabIndex = 14;
            this.labelind2.Text = "15.6 - 18.3 C°";
            // 
            // labelind1
            // 
            this.labelind1.AutoSize = true;
            this.labelind1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelind1.ForeColor = System.Drawing.Color.Teal;
            this.labelind1.Location = new System.Drawing.Point(62, 11);
            this.labelind1.Name = "labelind1";
            this.labelind1.Size = new System.Drawing.Size(71, 20);
            this.labelind1.TabIndex = 13;
            this.labelind1.Text = "< 15.6 C°";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Red;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(184, 81);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(47, 29);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Orange;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(184, 42);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(47, 29);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Yellow;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(184, 7);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 29);
            this.textBox4.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Green;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(9, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 29);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 29);
            this.textBox1.TabIndex = 8;
            // 
            // btnHideParameter
            // 
            this.btnHideParameter.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideParameter.ForeColor = System.Drawing.Color.Teal;
            this.btnHideParameter.Location = new System.Drawing.Point(119, 116);
            this.btnHideParameter.Name = "btnHideParameter";
            this.btnHideParameter.Size = new System.Drawing.Size(75, 30);
            this.btnHideParameter.TabIndex = 7;
            this.btnHideParameter.Text = "Hide";
            this.btnHideParameter.UseVisualStyleBackColor = true;
            this.btnHideParameter.Click += new System.EventHandler(this.btnHideParameter_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkBlue;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(9, 7);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 29);
            this.textBox3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Compartment3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Compartment2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Compartment1";
            // 
            // buttonResetPills
            // 
            this.buttonResetPills.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetPills.Location = new System.Drawing.Point(287, 11);
            this.buttonResetPills.Name = "buttonResetPills";
            this.buttonResetPills.Size = new System.Drawing.Size(163, 32);
            this.buttonResetPills.TabIndex = 34;
            this.buttonResetPills.Text = "Reset Pills";
            this.buttonResetPills.UseVisualStyleBackColor = true;
            this.buttonResetPills.Click += new System.EventHandler(this.buttonResetPills_Click);
            // 
            // panelPillNames
            // 
            this.panelPillNames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPillNames.Controls.Add(this.buttonCancelNameChange);
            this.panelPillNames.Controls.Add(this.buttonSaveNames);
            this.panelPillNames.Controls.Add(this.label4);
            this.panelPillNames.Controls.Add(this.label5);
            this.panelPillNames.Controls.Add(this.label6);
            this.panelPillNames.Controls.Add(this.InputC2);
            this.panelPillNames.Controls.Add(this.InputC3);
            this.panelPillNames.Controls.Add(this.InputC1);
            this.panelPillNames.Location = new System.Drawing.Point(257, 110);
            this.panelPillNames.Name = "panelPillNames";
            this.panelPillNames.Size = new System.Drawing.Size(332, 138);
            this.panelPillNames.TabIndex = 20;
            this.panelPillNames.Visible = false;
            // 
            // buttonCancelNameChange
            // 
            this.buttonCancelNameChange.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelNameChange.ForeColor = System.Drawing.Color.Teal;
            this.buttonCancelNameChange.Location = new System.Drawing.Point(28, 101);
            this.buttonCancelNameChange.Name = "buttonCancelNameChange";
            this.buttonCancelNameChange.Size = new System.Drawing.Size(81, 30);
            this.buttonCancelNameChange.TabIndex = 20;
            this.buttonCancelNameChange.Text = "Cancel";
            this.buttonCancelNameChange.UseVisualStyleBackColor = true;
            this.buttonCancelNameChange.Click += new System.EventHandler(this.buttonCancelUpdate_Click);
            // 
            // buttonSaveNames
            // 
            this.buttonSaveNames.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveNames.ForeColor = System.Drawing.Color.Teal;
            this.buttonSaveNames.Location = new System.Drawing.Point(115, 102);
            this.buttonSaveNames.Name = "buttonSaveNames";
            this.buttonSaveNames.Size = new System.Drawing.Size(75, 30);
            this.buttonSaveNames.TabIndex = 19;
            this.buttonSaveNames.Text = "Save";
            this.buttonSaveNames.UseVisualStyleBackColor = true;
            this.buttonSaveNames.Click += new System.EventHandler(this.buttonSaveNames_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(28, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Compartment 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(28, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Compartment 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(28, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Compartment 1";
            // 
            // InputC2
            // 
            this.InputC2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputC2.Location = new System.Drawing.Point(189, 40);
            this.InputC2.Multiline = true;
            this.InputC2.Name = "InputC2";
            this.InputC2.Size = new System.Drawing.Size(134, 29);
            this.InputC2.TabIndex = 2;
            // 
            // InputC3
            // 
            this.InputC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputC3.Location = new System.Drawing.Point(189, 73);
            this.InputC3.Multiline = true;
            this.InputC3.Name = "InputC3";
            this.InputC3.Size = new System.Drawing.Size(134, 29);
            this.InputC3.TabIndex = 1;
            // 
            // InputC1
            // 
            this.InputC1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputC1.Location = new System.Drawing.Point(189, 5);
            this.InputC1.Multiline = true;
            this.InputC1.Name = "InputC1";
            this.InputC1.Size = new System.Drawing.Size(134, 29);
            this.InputC1.TabIndex = 0;
            // 
            // textBoxC1
            // 
            this.textBoxC1.Enabled = false;
            this.textBoxC1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC1.Location = new System.Drawing.Point(182, 71);
            this.textBoxC1.Multiline = true;
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(107, 33);
            this.textBoxC1.TabIndex = 38;
            // 
            // textBoxC2
            // 
            this.textBoxC2.Enabled = false;
            this.textBoxC2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC2.Location = new System.Drawing.Point(314, 71);
            this.textBoxC2.Multiline = true;
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(107, 33);
            this.textBoxC2.TabIndex = 39;
            // 
            // textBoxC3
            // 
            this.textBoxC3.Enabled = false;
            this.textBoxC3.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC3.Location = new System.Drawing.Point(446, 71);
            this.textBoxC3.Multiline = true;
            this.textBoxC3.Name = "textBoxC3";
            this.textBoxC3.Size = new System.Drawing.Size(107, 33);
            this.textBoxC3.TabIndex = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(883, 451);
            this.Controls.Add(this.panelPillNames);
            this.Controls.Add(this.buttonResetPills);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelIndicator);
            this.Controls.Add(this.labelHeatIndex);
            this.Controls.Add(this.labelhumid);
            this.Controls.Add(this.labeltemp);
            this.Controls.Add(this.lblHeatIndexColor);
            this.Controls.Add(this.txtHeatIndex);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.buttonScheduleWizard);
            this.Controls.Add(this.btnInstantAccess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxC1);
            this.Controls.Add(this.textBoxC2);
            this.Controls.Add(this.textBoxC3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmaPal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPasswrodChange.ResumeLayout(false);
            this.panelPasswrodChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.panelIndicator.ResumeLayout(false);
            this.panelIndicator.PerformLayout();
            this.panelPillNames.ResumeLayout(false);
            this.panelPillNames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconUser;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelPasswrodChange;
        private System.Windows.Forms.Button buttonCancelUpdate;
        private System.Windows.Forms.Button buttonUpdatePsswd;
        private System.Windows.Forms.Label labelNewPsswd;
        private System.Windows.Forms.Label labelRetypePsswd;
        private System.Windows.Forms.Label labelCurrentPsswd;
        private System.Windows.Forms.TextBox textBoxNewPsswd;
        private System.Windows.Forms.TextBox textBoxRetypePsswd;
        private System.Windows.Forms.TextBox textBoxCurrentPsswd;
        private System.Windows.Forms.Button btnInstantAccess;
        private System.Windows.Forms.Button buttonScheduleWizard;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtHeatIndex;
        private System.Windows.Forms.Label lblHeatIndexColor;
        private System.Windows.Forms.Label labeltemp;
        private System.Windows.Forms.Label labelhumid;
        private System.Windows.Forms.Label labelHeatIndex;
        private System.Windows.Forms.Panel panelIndicator;
        private System.Windows.Forms.Button btnHideParameter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelind6;
        private System.Windows.Forms.Label labelind5;
        private System.Windows.Forms.Label labelind4;
        private System.Windows.Forms.Label labelind3;
        private System.Windows.Forms.Label labelind2;
        private System.Windows.Forms.Label labelind1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonResetPills;
        private System.Windows.Forms.Panel panelPillNames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputC2;
        private System.Windows.Forms.TextBox InputC3;
        private System.Windows.Forms.TextBox InputC1;
        private System.Windows.Forms.Button buttonSaveNames;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.TextBox textBoxC3;
        private System.Windows.Forms.Button buttonCancelNameChange;
        //   private System.Windows.Forms.Button buttonResetPills;
    }
}