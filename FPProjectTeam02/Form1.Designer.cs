namespace FPProjectTeam02
{
    partial class ClinicForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CreateProfileButton = new System.Windows.Forms.Button();
            this.BookAppointmentButton = new System.Windows.Forms.Button();
            this.EditAppointmentButton = new System.Windows.Forms.Button();
            this.DoctorListButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClinicMenu = new System.Windows.Forms.MenuStrip();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Douglas Clinic";
            // 
            // CreateProfileButton
            // 
            this.CreateProfileButton.Location = new System.Drawing.Point(148, 123);
            this.CreateProfileButton.Name = "CreateProfileButton";
            this.CreateProfileButton.Size = new System.Drawing.Size(154, 23);
            this.CreateProfileButton.TabIndex = 1;
            this.CreateProfileButton.Text = "Create Patient Profile";
            this.CreateProfileButton.UseVisualStyleBackColor = true;
            // 
            // BookAppointmentButton
            // 
            this.BookAppointmentButton.Location = new System.Drawing.Point(148, 176);
            this.BookAppointmentButton.Name = "BookAppointmentButton";
            this.BookAppointmentButton.Size = new System.Drawing.Size(154, 23);
            this.BookAppointmentButton.TabIndex = 2;
            this.BookAppointmentButton.Text = "Book Appointment";
            this.BookAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // EditAppointmentButton
            // 
            this.EditAppointmentButton.Location = new System.Drawing.Point(148, 229);
            this.EditAppointmentButton.Name = "EditAppointmentButton";
            this.EditAppointmentButton.Size = new System.Drawing.Size(154, 23);
            this.EditAppointmentButton.TabIndex = 3;
            this.EditAppointmentButton.Text = "Edit Appointment";
            this.EditAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // DoctorListButton
            // 
            this.DoctorListButton.Location = new System.Drawing.Point(148, 284);
            this.DoctorListButton.Name = "DoctorListButton";
            this.DoctorListButton.Size = new System.Drawing.Size(154, 23);
            this.DoctorListButton.TabIndex = 4;
            this.DoctorListButton.Text = "Doctor List";
            this.DoctorListButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(369, 304);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ClinicMenu
            // 
            this.ClinicMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ClinicMenu.Location = new System.Drawing.Point(0, 0);
            this.ClinicMenu.Name = "ClinicMenu";
            this.ClinicMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ClinicMenu.Size = new System.Drawing.Size(456, 24);
            this.ClinicMenu.TabIndex = 6;
            this.ClinicMenu.Text = "menuStrip1";
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoadingLabel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LoadingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadingLabel.ForeColor = System.Drawing.Color.White;
            this.LoadingLabel.Location = new System.Drawing.Point(9, 299);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(133, 33);
            this.LoadingLabel.TabIndex = 27;
            this.LoadingLabel.Text = "Please Wait, Loading.....";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadingLabel.Visible = false;
            // 
            // ClinicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 339);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DoctorListButton);
            this.Controls.Add(this.EditAppointmentButton);
            this.Controls.Add(this.BookAppointmentButton);
            this.Controls.Add(this.CreateProfileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClinicMenu);
            this.MainMenuStrip = this.ClinicMenu;
            this.Name = "ClinicForm";
            this.Text = "Clinic";
            this.Load += new System.EventHandler(this.ClinicForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateProfileButton;
        private System.Windows.Forms.Button BookAppointmentButton;
        private System.Windows.Forms.Button EditAppointmentButton;
        private System.Windows.Forms.Button DoctorListButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.MenuStrip ClinicMenu;
        private System.Windows.Forms.Label LoadingLabel;
    }
}

