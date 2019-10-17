namespace FPProjectTeam02
{
    partial class EditAppointmentForm
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
            this.PatientFirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EditAppointmentLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EditAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentGridView = new System.Windows.Forms.DataGridView();
            this.PatientIdTextBox = new System.Windows.Forms.TextBox();
            this.PatientIdLabel = new System.Windows.Forms.Label();
            this.EditAppointmentSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.PatientDatagridViewLookup = new System.Windows.Forms.DataGridView();
            this.PatientGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelAppointmentButton = new System.Windows.Forms.Button();
            this.ChangesSavedLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGridView)).BeginInit();
            this.EditAppointmentSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDatagridViewLookup)).BeginInit();
            this.PatientGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientFirstNameLabel
            // 
            this.PatientFirstNameLabel.AutoSize = true;
            this.PatientFirstNameLabel.Location = new System.Drawing.Point(6, 82);
            this.PatientFirstNameLabel.Name = "PatientFirstNameLabel";
            this.PatientFirstNameLabel.Size = new System.Drawing.Size(96, 13);
            this.PatientFirstNameLabel.TabIndex = 1;
            this.PatientFirstNameLabel.Text = "Patient First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Last Name:";
            // 
            // PatientLastNameTextBox
            // 
            this.PatientLastNameTextBox.Location = new System.Drawing.Point(120, 53);
            this.PatientLastNameTextBox.Name = "PatientLastNameTextBox";
            this.PatientLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatientLastNameTextBox.TabIndex = 2;
            // 
            // PatientFirstNameTextBox
            // 
            this.PatientFirstNameTextBox.Location = new System.Drawing.Point(120, 79);
            this.PatientFirstNameTextBox.Name = "PatientFirstNameTextBox";
            this.PatientFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatientFirstNameTextBox.TabIndex = 3;
            // 
            // EditAppointmentLabel
            // 
            this.EditAppointmentLabel.AutoSize = true;
            this.EditAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAppointmentLabel.Location = new System.Drawing.Point(336, 9);
            this.EditAppointmentLabel.Name = "EditAppointmentLabel";
            this.EditAppointmentLabel.Size = new System.Drawing.Size(170, 24);
            this.EditAppointmentLabel.TabIndex = 19;
            this.EditAppointmentLabel.Text = "Edit Appointment";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(735, 516);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "Finish";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(24, 514);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "LookUp";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EditAppointmentButton
            // 
            this.EditAppointmentButton.Location = new System.Drawing.Point(654, 516);
            this.EditAppointmentButton.Name = "EditAppointmentButton";
            this.EditAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.EditAppointmentButton.TabIndex = 16;
            this.EditAppointmentButton.Text = "Edit";
            this.EditAppointmentButton.UseVisualStyleBackColor = true;
            this.EditAppointmentButton.Click += new System.EventHandler(this.EditAppointmentButton_Click);
            // 
            // AppointmentGridView
            // 
            this.AppointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGridView.Location = new System.Drawing.Point(280, 249);
            this.AppointmentGridView.Name = "AppointmentGridView";
            this.AppointmentGridView.Size = new System.Drawing.Size(524, 222);
            this.AppointmentGridView.TabIndex = 15;
            // 
            // PatientIdTextBox
            // 
            this.PatientIdTextBox.Location = new System.Drawing.Point(120, 30);
            this.PatientIdTextBox.Name = "PatientIdTextBox";
            this.PatientIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatientIdTextBox.TabIndex = 10;
            // 
            // PatientIdLabel
            // 
            this.PatientIdLabel.AutoSize = true;
            this.PatientIdLabel.Location = new System.Drawing.Point(6, 33);
            this.PatientIdLabel.Name = "PatientIdLabel";
            this.PatientIdLabel.Size = new System.Drawing.Size(57, 13);
            this.PatientIdLabel.TabIndex = 9;
            this.PatientIdLabel.Text = "Patient ID:";
            // 
            // EditAppointmentSearchGroupBox
            // 
            this.EditAppointmentSearchGroupBox.Controls.Add(this.PatientFirstNameLabel);
            this.EditAppointmentSearchGroupBox.Controls.Add(this.PatientIdTextBox);
            this.EditAppointmentSearchGroupBox.Controls.Add(this.label1);
            this.EditAppointmentSearchGroupBox.Controls.Add(this.PatientIdLabel);
            this.EditAppointmentSearchGroupBox.Controls.Add(this.PatientLastNameTextBox);
            this.EditAppointmentSearchGroupBox.Controls.Add(this.PatientFirstNameTextBox);
            this.EditAppointmentSearchGroupBox.Location = new System.Drawing.Point(24, 39);
            this.EditAppointmentSearchGroupBox.Name = "EditAppointmentSearchGroupBox";
            this.EditAppointmentSearchGroupBox.Size = new System.Drawing.Size(243, 459);
            this.EditAppointmentSearchGroupBox.TabIndex = 20;
            this.EditAppointmentSearchGroupBox.TabStop = false;
            this.EditAppointmentSearchGroupBox.Text = "Search Credentials";
            // 
            // PatientDatagridViewLookup
            // 
            this.PatientDatagridViewLookup.AllowUserToAddRows = false;
            this.PatientDatagridViewLookup.AllowUserToDeleteRows = false;
            this.PatientDatagridViewLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientDatagridViewLookup.Location = new System.Drawing.Point(6, 16);
            this.PatientDatagridViewLookup.Name = "PatientDatagridViewLookup";
            this.PatientDatagridViewLookup.ReadOnly = true;
            this.PatientDatagridViewLookup.Size = new System.Drawing.Size(524, 182);
            this.PatientDatagridViewLookup.TabIndex = 12;
            // 
            // PatientGroupBox
            // 
            this.PatientGroupBox.Controls.Add(this.PatientDatagridViewLookup);
            this.PatientGroupBox.Location = new System.Drawing.Point(274, 39);
            this.PatientGroupBox.Name = "PatientGroupBox";
            this.PatientGroupBox.Size = new System.Drawing.Size(536, 204);
            this.PatientGroupBox.TabIndex = 22;
            this.PatientGroupBox.TabStop = false;
            this.PatientGroupBox.Text = "Select the Patient here to see appointments";
            // 
            // CancelAppointmentButton
            // 
            this.CancelAppointmentButton.Location = new System.Drawing.Point(528, 516);
            this.CancelAppointmentButton.Name = "CancelAppointmentButton";
            this.CancelAppointmentButton.Size = new System.Drawing.Size(120, 23);
            this.CancelAppointmentButton.TabIndex = 21;
            this.CancelAppointmentButton.Text = "Cancel Appointment";
            this.CancelAppointmentButton.UseVisualStyleBackColor = true;
            this.CancelAppointmentButton.Click += new System.EventHandler(this.CancelAppointmentButton_Click_1);
            // 
            // ChangesSavedLabel
            // 
            this.ChangesSavedLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangesSavedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChangesSavedLabel.ForeColor = System.Drawing.Color.Red;
            this.ChangesSavedLabel.Location = new System.Drawing.Point(280, 474);
            this.ChangesSavedLabel.Name = "ChangesSavedLabel";
            this.ChangesSavedLabel.Size = new System.Drawing.Size(524, 24);
            this.ChangesSavedLabel.TabIndex = 25;
            this.ChangesSavedLabel.Text = "You changes were Saved!";
            this.ChangesSavedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoadingLabel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LoadingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadingLabel.ForeColor = System.Drawing.Color.White;
            this.LoadingLabel.Location = new System.Drawing.Point(671, 3);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(133, 33);
            this.LoadingLabel.TabIndex = 26;
            this.LoadingLabel.Text = "Please Wait, Loading.....";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 549);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.ChangesSavedLabel);
            this.Controls.Add(this.EditAppointmentLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EditAppointmentButton);
            this.Controls.Add(this.AppointmentGridView);
            this.Controls.Add(this.EditAppointmentSearchGroupBox);
            this.Controls.Add(this.PatientGroupBox);
            this.Controls.Add(this.CancelAppointmentButton);
            this.Name = "EditAppointmentForm";
            this.Text = "EditAppointment";
            this.Load += new System.EventHandler(this.EditAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGridView)).EndInit();
            this.EditAppointmentSearchGroupBox.ResumeLayout(false);
            this.EditAppointmentSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDatagridViewLookup)).EndInit();
            this.PatientGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientFirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatientLastNameTextBox;
        private System.Windows.Forms.TextBox PatientFirstNameTextBox;
        private System.Windows.Forms.Label EditAppointmentLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button EditAppointmentButton;
        private System.Windows.Forms.DataGridView AppointmentGridView;
        private System.Windows.Forms.TextBox PatientIdTextBox;
        private System.Windows.Forms.Label PatientIdLabel;
        private System.Windows.Forms.GroupBox EditAppointmentSearchGroupBox;
        private System.Windows.Forms.DataGridView PatientDatagridViewLookup;
        private System.Windows.Forms.GroupBox PatientGroupBox;
        private System.Windows.Forms.Button CancelAppointmentButton;
        private System.Windows.Forms.Label ChangesSavedLabel;
        private System.Windows.Forms.Label LoadingLabel;
    }
}