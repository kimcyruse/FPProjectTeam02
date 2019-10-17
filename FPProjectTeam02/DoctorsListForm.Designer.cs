namespace FPProjectTeam02
{
    partial class DoctorsListForm
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
            this.DoctorNameListBox = new System.Windows.Forms.ListBox();
            this.DoctorInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DoctorAppointmentGridView = new System.Windows.Forms.DataGridView();
            this.DoctorListGroupBox = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DoctorListFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.GenderFilterListView = new System.Windows.Forms.ListView();
            this.TimeFilterListView = new System.Windows.Forms.ListView();
            this.TotalDoctorOutputLabel = new System.Windows.Forms.Label();
            this.TotalDoctorLabel = new System.Windows.Forms.Label();
            this.CurrentPatientLabel = new System.Windows.Forms.Label();
            this.CurrentPatientOututLabel = new System.Windows.Forms.Label();
            this.DoctorInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorAppointmentGridView)).BeginInit();
            this.DoctorListGroupBox.SuspendLayout();
            this.DoctorListFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctors\' Info List";
            // 
            // DoctorNameListBox
            // 
            this.DoctorNameListBox.FormattingEnabled = true;
            this.DoctorNameListBox.ItemHeight = 16;
            this.DoctorNameListBox.Location = new System.Drawing.Point(9, 23);
            this.DoctorNameListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorNameListBox.Name = "DoctorNameListBox";
            this.DoctorNameListBox.Size = new System.Drawing.Size(191, 164);
            this.DoctorNameListBox.TabIndex = 1;
            // 
            // DoctorInfoGroupBox
            // 
            this.DoctorInfoGroupBox.Controls.Add(this.DoctorAppointmentGridView);
            this.DoctorInfoGroupBox.Location = new System.Drawing.Point(22, 259);
            this.DoctorInfoGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorInfoGroupBox.Name = "DoctorInfoGroupBox";
            this.DoctorInfoGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorInfoGroupBox.Size = new System.Drawing.Size(932, 261);
            this.DoctorInfoGroupBox.TabIndex = 3;
            this.DoctorInfoGroupBox.TabStop = false;
            this.DoctorInfoGroupBox.Text = "Doctor\'s Info";
            // 
            // DoctorAppointmentGridView
            // 
            this.DoctorAppointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorAppointmentGridView.Location = new System.Drawing.Point(9, 22);
            this.DoctorAppointmentGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorAppointmentGridView.Name = "DoctorAppointmentGridView";
            this.DoctorAppointmentGridView.Size = new System.Drawing.Size(923, 231);
            this.DoctorAppointmentGridView.TabIndex = 0;
            // 
            // DoctorListGroupBox
            // 
            this.DoctorListGroupBox.Controls.Add(this.DoctorNameListBox);
            this.DoctorListGroupBox.Location = new System.Drawing.Point(13, 59);
            this.DoctorListGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorListGroupBox.Name = "DoctorListGroupBox";
            this.DoctorListGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorListGroupBox.Size = new System.Drawing.Size(208, 193);
            this.DoctorListGroupBox.TabIndex = 4;
            this.DoctorListGroupBox.TabStop = false;
            this.DoctorListGroupBox.Text = "Doctor List";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(854, 534);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 28);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // DoctorListFilterGroupBox
            // 
            this.DoctorListFilterGroupBox.Controls.Add(this.GenderFilterListView);
            this.DoctorListFilterGroupBox.Controls.Add(this.TimeFilterListView);
            this.DoctorListFilterGroupBox.Location = new System.Drawing.Point(229, 58);
            this.DoctorListFilterGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorListFilterGroupBox.Name = "DoctorListFilterGroupBox";
            this.DoctorListFilterGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorListFilterGroupBox.Size = new System.Drawing.Size(400, 193);
            this.DoctorListFilterGroupBox.TabIndex = 5;
            this.DoctorListFilterGroupBox.TabStop = false;
            this.DoctorListFilterGroupBox.Text = "Filter";
            // 
            // GenderFilterListView
            // 
            this.GenderFilterListView.CheckBoxes = true;
            this.GenderFilterListView.Location = new System.Drawing.Point(204, 23);
            this.GenderFilterListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenderFilterListView.Name = "GenderFilterListView";
            this.GenderFilterListView.Size = new System.Drawing.Size(187, 162);
            this.GenderFilterListView.TabIndex = 2;
            this.GenderFilterListView.UseCompatibleStateImageBehavior = false;
            this.GenderFilterListView.View = System.Windows.Forms.View.Details;
            this.GenderFilterListView.SelectedIndexChanged += new System.EventHandler(this.GenderFilterListView_SelectedIndexChanged);
            // 
            // TimeFilterListView
            // 
            this.TimeFilterListView.CheckBoxes = true;
            this.TimeFilterListView.Location = new System.Drawing.Point(8, 23);
            this.TimeFilterListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeFilterListView.Name = "TimeFilterListView";
            this.TimeFilterListView.Size = new System.Drawing.Size(188, 162);
            this.TimeFilterListView.TabIndex = 0;
            this.TimeFilterListView.UseCompatibleStateImageBehavior = false;
            this.TimeFilterListView.View = System.Windows.Forms.View.Details;
            this.TimeFilterListView.SelectedIndexChanged += new System.EventHandler(this.TimeFilterListView_SelectedIndexChanged);
            // 
            // TotalDoctorOutputLabel
            // 
            this.TotalDoctorOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalDoctorOutputLabel.Location = new System.Drawing.Point(155, 528);
            this.TotalDoctorOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalDoctorOutputLabel.Name = "TotalDoctorOutputLabel";
            this.TotalDoctorOutputLabel.Size = new System.Drawing.Size(69, 27);
            this.TotalDoctorOutputLabel.TabIndex = 12;
            this.TotalDoctorOutputLabel.Text = "0";
            this.TotalDoctorOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalDoctorLabel
            // 
            this.TotalDoctorLabel.AutoSize = true;
            this.TotalDoctorLabel.Location = new System.Drawing.Point(28, 534);
            this.TotalDoctorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalDoctorLabel.Name = "TotalDoctorLabel";
            this.TotalDoctorLabel.Size = new System.Drawing.Size(94, 17);
            this.TotalDoctorLabel.TabIndex = 11;
            this.TotalDoctorLabel.Text = "Total Doctor: ";
            // 
            // CurrentPatientLabel
            // 
            this.CurrentPatientLabel.AutoSize = true;
            this.CurrentPatientLabel.Location = new System.Drawing.Point(653, 59);
            this.CurrentPatientLabel.Name = "CurrentPatientLabel";
            this.CurrentPatientLabel.Size = new System.Drawing.Size(158, 17);
            this.CurrentPatientLabel.TabIndex = 13;
            this.CurrentPatientLabel.Text = "Current Patient Filtered:";
            // 
            // CurrentPatientOututLabel
            // 
            this.CurrentPatientOututLabel.AutoSize = true;
            this.CurrentPatientOututLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPatientOututLabel.Location = new System.Drawing.Point(787, 132);
            this.CurrentPatientOututLabel.Name = "CurrentPatientOututLabel";
            this.CurrentPatientOututLabel.Size = new System.Drawing.Size(32, 32);
            this.CurrentPatientOututLabel.TabIndex = 14;
            this.CurrentPatientOututLabel.Text = "0";
            // 
            // DoctorsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 571);
            this.Controls.Add(this.CurrentPatientOututLabel);
            this.Controls.Add(this.CurrentPatientLabel);
            this.Controls.Add(this.TotalDoctorOutputLabel);
            this.Controls.Add(this.TotalDoctorLabel);
            this.Controls.Add(this.DoctorListFilterGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DoctorListGroupBox);
            this.Controls.Add(this.DoctorInfoGroupBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoctorsListForm";
            this.Text = "DoctorsList";
            this.Load += new System.EventHandler(this.DoctorsListForm_Load);
            this.DoctorInfoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorAppointmentGridView)).EndInit();
            this.DoctorListGroupBox.ResumeLayout(false);
            this.DoctorListFilterGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox DoctorNameListBox;
        private System.Windows.Forms.GroupBox DoctorInfoGroupBox;
        private System.Windows.Forms.GroupBox DoctorListGroupBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView DoctorAppointmentGridView;
        private System.Windows.Forms.GroupBox DoctorListFilterGroupBox;
        private System.Windows.Forms.ListView GenderFilterListView;
        private System.Windows.Forms.ListView TimeFilterListView;
        private System.Windows.Forms.Label TotalDoctorOutputLabel;
        private System.Windows.Forms.Label TotalDoctorLabel;
        private System.Windows.Forms.Label CurrentPatientLabel;
        private System.Windows.Forms.Label CurrentPatientOututLabel;
    }
}