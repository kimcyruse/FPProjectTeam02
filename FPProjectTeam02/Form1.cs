using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FPProjectTeam02.Entities;

namespace FPProjectTeam02
{
    public partial class ClinicForm : Form
    {
        //Declare Menu Items
        ToolStripMenuItem FileMenu = new ToolStripMenuItem("File");
        ToolStripMenuItem OpenMenu = new ToolStripMenuItem("Open");
        ToolStripMenuItem QuitMenu = new ToolStripMenuItem("Quit");
        ToolStripMenuItem HelpMenu = new ToolStripMenuItem("Help");
        ToolStripMenuItem AboutMenu = new ToolStripMenuItem("About");

        // CSV Parser object instantiate
        CSVParser myParser = new CSVParser();

        public ClinicForm()
        {
            InitializeComponent();
        }

        private void ClinicForm_Load(object sender, EventArgs e)
        {
            
            using (ClinicContext ctx = new ClinicContext())
            {
                if(!ctx.Database.Exists())
                {
                    MessageBox.Show("Possibly this is the first time the application is being used\n" + 
                                    "You need to load the data from a csv file\n\n"
                                    + "GO to Menu bar -> File -> Open ( To open your csv file)\n"
                                    + "The file name: ModifiedHealthCare_2\nThe file location: In the same folder of the application");

                    
                } 
            }

            SetupMenu(); // Setup menu when from load

            //Trigger Events for menu bar
            OpenMenu.Click += MenuActionHandler;
            AboutMenu.Click += MenuActionHandler;
            QuitMenu.Click += MenuActionHandler;

            // Call the even for each form on load form
            CreateProfileButton.Click += LoadForm;
            BookAppointmentButton.Click += LoadForm;
            EditAppointmentButton.Click += LoadForm;
            DoctorListButton.Click += LoadForm;
            CloseButton.Click += ExitButton_Click;
        }

        // Events for trigger the proper form when the respective form button is clicked
        private void LoadForm(object sender, EventArgs e)
        {
            
            if (sender == CreateProfileButton) // -------- Create Patient Form
            {
                Form CreatePatient = new CreatePatienForm();
                CreatePatient.Show();
            }
            else if (sender == BookAppointmentButton)  // -------- Book Appointment Form
            {
                Form BookAppointment = new BookAppointmentForm();
                BookAppointment.Show();
            }
            else if(sender == EditAppointmentButton) // -------- Edit Appointment Form
            {
                Form EditAppointment = new EditAppointmentForm();
                EditAppointment.Show();
            }
            else if(sender == DoctorListButton) // -------- Doctor List Form
            {
                Form DoctorsList = new DoctorsListForm();
                DoctorsList.Show();
            }
        }

        // Event handler to manage the menu strip 
        private void MenuActionHandler(object sender, EventArgs e)
        {
            switch (sender.ToString())
            {
                case "File":
                    break;
                case "Open":
                    LoadingLabel.Visible = true;
                    myParser.ParseData();  // -------- OpenFileDialog ask for CSV file open
                    break;
                case "About":
                    // Information about the application
                    MessageBox.Show("Term Project - Client Server System Course \n This is the Douglas Clinic Project preformed by TEAM 2");
                    break;
                case "Help":
                    break;
                case "Quit":
                    this.Close(); // Close the application
                    break;
            }
            LoadingLabel.Visible = false;
        }

        // Method to setup the menu
        private void SetupMenu()
        {
            //Set the properties of menustrip
            FileMenu.Text = "File";
            OpenMenu.Text = "Open";
            QuitMenu.Text = "Quit";
            HelpMenu.Text = "Help";
            AboutMenu.Text = "About";

            //Add the menu item to the menustrip
            ClinicMenu.Items.Add(FileMenu);

            ClinicMenu.Items.Add(HelpMenu);

            //Add the DropDownItems
            FileMenu.DropDownItems.Add(OpenMenu);
            FileMenu.DropDownItems.Add(QuitMenu);

            HelpMenu.DropDownItems.Add(AboutMenu);
        }
        

        //Close the application event
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
