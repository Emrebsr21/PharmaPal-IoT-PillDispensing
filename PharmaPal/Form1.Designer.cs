namespace PharmaPal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textUserPsswd = new System.Windows.Forms.TextBox();
            this.textUserLogin = new System.Windows.Forms.TextBox();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelClear = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelSecurity = new System.Windows.Forms.Panel();
            this.pictureBoxSecurity = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textUserPsswd
            // 
            this.textUserPsswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserPsswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserPsswd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textUserPsswd.Location = new System.Drawing.Point(518, 131);
            this.textUserPsswd.Multiline = true;
            this.textUserPsswd.Name = "textUserPsswd";
            this.textUserPsswd.PasswordChar = '*';
            this.textUserPsswd.Size = new System.Drawing.Size(190, 24);
            this.textUserPsswd.TabIndex = 19;
            // 
            // textUserLogin
            // 
            this.textUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textUserLogin.Location = new System.Drawing.Point(518, 69);
            this.textUserLogin.Multiline = true;
            this.textUserLogin.Name = "textUserLogin";
            this.textUserLogin.Size = new System.Drawing.Size(190, 24);
            this.textUserLogin.TabIndex = 18;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelExit.Location = new System.Drawing.Point(562, 235);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(54, 28);
            this.labelExit.TabIndex = 17;
            this.labelExit.Text = "Exit";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelClear.Location = new System.Drawing.Point(580, 166);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(141, 28);
            this.labelClear.TabIndex = 16;
            this.labelClear.Text = "Clear Fields";
            this.labelClear.Click += new System.EventHandler(this.labelClear_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLogin.Location = new System.Drawing.Point(472, 197);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(236, 35);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "LOG IN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelSecurity
            // 
            this.panelSecurity.BackColor = System.Drawing.Color.Teal;
            this.panelSecurity.Location = new System.Drawing.Point(472, 161);
            this.panelSecurity.Name = "panelSecurity";
            this.panelSecurity.Size = new System.Drawing.Size(236, 2);
            this.panelSecurity.TabIndex = 13;
            // 
            // pictureBoxSecurity
            // 
            this.pictureBoxSecurity.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSecurity.Image")));
            this.pictureBoxSecurity.Location = new System.Drawing.Point(472, 126);
            this.pictureBoxSecurity.Name = "pictureBoxSecurity";
            this.pictureBoxSecurity.Size = new System.Drawing.Size(40, 34);
            this.pictureBoxSecurity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSecurity.TabIndex = 11;
            this.pictureBoxSecurity.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Teal;
            this.panelUser.Location = new System.Drawing.Point(472, 99);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(236, 2);
            this.panelUser.TabIndex = 14;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(472, 64);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(40, 34);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 12;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelLogin.Location = new System.Drawing.Point(522, 21);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(139, 40);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "LOG IN";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(24, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(411, 273);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(758, 332);
            this.Controls.Add(this.textUserPsswd);
            this.Controls.Add(this.textUserLogin);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelSecurity);
            this.Controls.Add(this.pictureBoxSecurity);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUserPsswd;
        private System.Windows.Forms.TextBox textUserLogin;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelSecurity;
        private System.Windows.Forms.PictureBox pictureBoxSecurity;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

