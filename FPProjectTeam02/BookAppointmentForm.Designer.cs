namespace FPProjectTeam02
{
    partial class BookAppointmentForm
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
            this.BookAppointmentLabel = new System.Windows.Forms.Label();
            this.BookButton = new System.Windows.Forms.Button();
            this.AppointmentTimeLabel = new System.Windows.Forms.Label();
            this.AppointmentDateLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PatientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientFirstNameLabel = new System.Windows.Forms.Label();
            this.PatientLastNameLabel = new System.Windows.Forms.Label();
            this.AppointmentTimeBoxcomboBox = new System.Windows.Forms.ComboBox();
            this.SeelectDoctorLabel = new System.Windows.Forms.Label();
            this.SelectDoctorComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BookAppointmentLabel
            // 
            this.BookAppointmentLabel.AutoSize = true;
            this.BookAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAppointmentLabel.Location = new System.Drawing.Point(82, 21);
            this.BookAppointmentLabel.Name = "BookAppointmentLabel";
            this.BookAppointmentLabel.Size = new System.Drawing.Size(181, 24);
            this.BookAppointmentLabel.TabIndex = 0;
            this.BookAppointmentLabel.Text = "Book Appointment";
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(121, 268);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(98, 24);
            this.BookButton.TabIndex = 30;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = true;
            // 
            // AppointmentTimeLabel
            // 
            this.AppointmentTimeLabel.AutoSize = true;
            this.AppointmentTimeLabel.Location = new System.Drawing.Point(53, 175);
            this.AppointmentTimeLabel.Name = "AppointmentTimeLabel";
            this.AppointmentTimeLabel.Size = new System.Drawing.Size(92, 13);
            this.AppointmentTimeLabel.TabIndex = 27;
            this.AppointmentTimeLabel.Text = "Appointment Time";
            // 
            // AppointmentDateLabel
            // 
            this.AppointmentDateLabel.AutoSize = true;
            this.AppointmentDateLabel.Location = new System.Drawing.Point(53, 135);
            this.AppointmentDateLabel.Name = "AppointmentDateLabel";
            this.AppointmentDateLabel.Size = new System.Drawing.Size(92, 13);
            this.AppointmentDateLabel.TabIndex = 26;
            this.AppointmentDateLabel.Text = "Appointment Date";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(257, 308);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 31;
            this.ExitButton.Text = "Finish";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // PatientFirstNameTextBox
            // 
            this.PatientFirstNameTextBox.Location = new System.Drawing.Point(156, 96);
            this.PatientFirstNameTextBox.Name = "PatientFirstNameTextBox";
            this.PatientFirstNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.PatientFirstNameTextBox.TabIndex = 35;
            // 
            // PatientLastNameTextBox
            // 
            this.PatientLastNameTextBox.Location = new System.Drawing.Point(156, 56);
            this.PatientLastNameTextBox.Name = "PatientLastNameTextBox";
            this.PatientLastNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.PatientLastNameTextBox.TabIndex = 34;
            // 
            // PatientFirstNameLabel
            // 
            this.PatientFirstNameLabel.AutoSize = true;
            this.PatientFirstNameLabel.Location = new System.Drawing.Point(53, 99);
            this.PatientFirstNameLabel.Name = "PatientFirstNameLabel";
            this.PatientFirstNameLabel.Size = new System.Drawing.Size(96, 13);
            this.PatientFirstNameLabel.TabIndex = 33;
            this.PatientFirstNameLabel.Text = "Patient First Name:";
            // 
            // PatientLastNameLabel
            // 
            this.PatientLastNameLabel.AutoSize = true;
            this.PatientLastNameLabel.Location = new System.Drawing.Point(53, 59);
            this.PatientLastNameLabel.Name = "PatientLastNameLabel";
            this.PatientLastNameLabel.Size = new System.Drawing.Size(97, 13);
            this.PatientLastNameLabel.TabIndex = 32;
            this.PatientLastNameLabel.Text = "Patient Last Name:";
            // 
            // AppointmentTimeBoxcomboBox
            // 
            this.AppointmentTimeBoxcomboBox.FormattingEnabled = true;
            this.AppointmentTimeBoxcomboBox.Items.AddRange(new object[] {
            "9.00 A.M",
            "9.30 A.M",
            "10.00 A.M",
            "10.30 A.M",
            "11.00 A.M",
            "11.30 A.M",
            "12.00 P.M",
            "12.30 P.M",
            "1.00 P.M",
            "1.30 P.M",
            "2.00 P.M",
            "2.30 P.M",
            "3.00 P.M",
            "3.30 P.M",
            "4.00 P.M",
            "4.30 P.M",
            "5.00 P.M",
            "5.30 P.M"});
            this.AppointmentTimeBoxcomboBox.Location = new System.Drawing.Point(156, 167);
            this.AppointmentTimeBoxcomboBox.Name = "AppointmentTimeBoxcomboBox";
            this.AppointmentTimeBoxcomboBox.Size = new System.Drawing.Size(141, 21);
            this.AppointmentTimeBoxcomboBox.TabIndex = 36;
            // 
            // SeelectDoctorLabel
            // 
            this.SeelectDoctorLabel.AutoSize = true;
            this.SeelectDoctorLabel.Location = new System.Drawing.Point(53, 210);
            this.SeelectDoctorLabel.Name = "SeelectDoctorLabel";
            this.SeelectDoctorLabel.Size = new System.Drawing.Size(75, 13);
            this.SeelectDoctorLabel.TabIndex = 37;
            this.SeelectDoctorLabel.Text = "Select Doctor:";
            // 
            // SelectDoctorComboBox
            // 
            this.SelectDoctorComboBox.FormattingEnabled = true;
            this.SelectDoctorComboBox.Items.AddRange(new object[] {
            "Milo Edler",
            "Filippo McCuthais",
            "Reggi Wilkes",
            "Marji Keilloh",
            "Orlan Wadlow",
            "Guthrey Stoffel",
            "Gabi Ceaser",
            "Rodi Meece",
            "Lizzie Zeal",
            "Oralie Bothen"});
            this.SelectDoctorComboBox.Location = new System.Drawing.Point(156, 207);
            this.SelectDoctorComboBox.Name = "SelectDoctorComboBox";
            this.SelectDoctorComboBox.Size = new System.Drawing.Size(141, 21);
            this.SelectDoctorComboBox.TabIndex = 38;
            // 
            // AppointmentDateTimePicker1
            // 
            this.AppointmentDateTimePicker1.Location = new System.Drawing.Point(156, 129);
            this.AppointmentDateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.AppointmentDateTimePicker1.MinDate = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            this.AppointmentDateTimePicker1.Name = "AppointmentDateTimePicker1";
            this.AppointmentDateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.AppointmentDateTimePicker1.TabIndex = 29;
            this.AppointmentDateTimePicker1.Value = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            // 
            // BookAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 358);
            this.Controls.Add(this.SelectDoctorComboBox);
            this.Controls.Add(this.SeelectDoctorLabel);
            this.Controls.Add(this.AppointmentTimeBoxcomboBox);
            this.Controls.Add(this.PatientFirstNameTextBox);
            this.Controls.Add(this.PatientLastNameTextBox);
            this.Controls.Add(this.PatientFirstNameLabel);
            this.Controls.Add(this.PatientLastNameLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.AppointmentDateTimePicker1);
            this.Controls.Add(this.AppointmentTimeLabel);
            this.Controls.Add(this.AppointmentDateLabel);
            this.Controls.Add(this.BookAppointmentLabel);
            this.Name = "BookAppointmentForm";
            this.Text = "BookAppointment";
            this.Load += new System.EventHandler(this.BookAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookAppointmentLabel;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Label AppointmentTimeLabel;
        private System.Windows.Forms.Label AppointmentDateLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox PatientFirstNameTextBox;
        private System.Windows.Forms.TextBox PatientLastNameTextBox;
        private System.Windows.Forms.Label PatientFirstNameLabel;
        private System.Windows.Forms.Label PatientLastNameLabel;
        private System.Windows.Forms.ComboBox AppointmentTimeBoxcomboBox;
        private System.Windows.Forms.Label SeelectDoctorLabel;
        private System.Windows.Forms.ComboBox SelectDoctorComboBox;
        private System.Windows.Forms.DateTimePicker AppointmentDateTimePicker1;
    }
}