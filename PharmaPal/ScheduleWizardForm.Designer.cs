namespace PharmaPal
{
    partial class ScheduleWizardForm
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
            this.buttonAddSchedule = new System.Windows.Forms.Button();
            this.buttonSendSchedule = new System.Windows.Forms.Button();
            this.panelScroll = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDisplayCurrentSchedule = new System.Windows.Forms.Button();
            this.buttonResetWizard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddSchedule
            // 
            this.buttonAddSchedule.Location = new System.Drawing.Point(659, 12);
            this.buttonAddSchedule.Name = "buttonAddSchedule";
            this.buttonAddSchedule.Size = new System.Drawing.Size(141, 82);
            this.buttonAddSchedule.TabIndex = 0;
            this.buttonAddSchedule.Text = "AddSchedule";
            this.buttonAddSchedule.UseVisualStyleBackColor = true;
            this.buttonAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // buttonSendSchedule
            // 
            this.buttonSendSchedule.Location = new System.Drawing.Point(659, 121);
            this.buttonSendSchedule.Name = "buttonSendSchedule";
            this.buttonSendSchedule.Size = new System.Drawing.Size(141, 82);
            this.buttonSendSchedule.TabIndex = 1;
            this.buttonSendSchedule.Text = "Send Schedule";
            this.buttonSendSchedule.UseVisualStyleBackColor = true;
            this.buttonSendSchedule.Click += new System.EventHandler(this.btnScheduleTasks_Click);
            // 
            // panelScroll
            // 
            this.panelScroll.AutoScroll = true;
            this.panelScroll.BackColor = System.Drawing.Color.MistyRose;
            this.panelScroll.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelScroll.Location = new System.Drawing.Point(10, 10);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(643, 543);
            this.panelScroll.TabIndex = 2;
            this.panelScroll.WrapContents = false;
            // 
            // buttonDisplayCurrentSchedule
            // 
            this.buttonDisplayCurrentSchedule.Location = new System.Drawing.Point(659, 225);
            this.buttonDisplayCurrentSchedule.Name = "buttonDisplayCurrentSchedule";
            this.buttonDisplayCurrentSchedule.Size = new System.Drawing.Size(141, 82);
            this.buttonDisplayCurrentSchedule.TabIndex = 3;
            this.buttonDisplayCurrentSchedule.Text = "Display Schedule";
            this.buttonDisplayCurrentSchedule.UseVisualStyleBackColor = true;
            this.buttonDisplayCurrentSchedule.Click += new System.EventHandler(this.btnDisplayCurrentSchedule_Click);
            // 
            // buttonResetWizard
            // 
            this.buttonResetWizard.Location = new System.Drawing.Point(659, 329);
            this.buttonResetWizard.Name = "buttonResetWizard";
            this.buttonResetWizard.Size = new System.Drawing.Size(141, 82);
            this.buttonResetWizard.TabIndex = 4;
            this.buttonResetWizard.Text = "Reset Wizard";
            this.buttonResetWizard.UseVisualStyleBackColor = true;
            this.buttonResetWizard.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // ScheduleWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 607);
            this.Controls.Add(this.buttonResetWizard);
            this.Controls.Add(this.buttonDisplayCurrentSchedule);
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.buttonSendSchedule);
            this.Controls.Add(this.buttonAddSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScheduleWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleWizardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSchedule;
        private System.Windows.Forms.Button buttonSendSchedule;
        private System.Windows.Forms.FlowLayoutPanel panelScroll;
        private System.Windows.Forms.Button buttonDisplayCurrentSchedule;
        private System.Windows.Forms.Button buttonResetWizard;
    }
}