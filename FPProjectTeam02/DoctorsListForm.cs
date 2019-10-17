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
using System.IO;

namespace FPProjectTeam02
{
    public partial class DoctorsListForm : Form
    {
        //Clinic Context global varible 
        ClinicContext clinicCtx;

        // List for collection of checked item when filterring
        List<string> checkedTime = new List<string>();  // <---------- for TIME filter 
        List<string> checkedGender = new List<string>();  // <---------- for GENDER filter 

        CSVParser myParser = new CSVParser(); // CSV Parse object instantiate

        public DoctorsListForm()
        {
            InitializeComponent();
        }

        private void DoctorsListForm_Load(object sender, EventArgs e)
        {
            clinicCtx = new ClinicContext();  //Clinic Context instantiate as global for widely use

            PopulateDoctorListBox(); // Populate the doctor name in the list box

            //Set up the list view for the fitler 
            SetUpListViewHeader(TimeFilterListView, "Time"); //<-------- for TIME filter
            SetUpListViewHeader(GenderFilterListView, "Gender"); //<-------- for GENDER filter


            //Populate the time filter list view
            PopulateTimeListView(); 
            // Populate the gender filter list view
            PopulateGenderListView();

            // Set check for all the items in gender filter listview
            SetItemListCheck(GenderFilterListView, "check");

            // Set uncheck for all the items in gender filter listview
            SetItemListCheck(TimeFilterListView, "uncheck");

            // Collect the checked item in the filter initially when the doctor form load
            checkedGender = GetCheckFilterItem(GenderFilterListView);
            checkedTime = GetCheckFilterItem(TimeFilterListView);

            EventHandlerToggle(true);

            ExitButton.Click += CloseForm; //Close form the exit click
        }

        private void EventHandlerToggle(bool toggle)
        {
            if (toggle == true)
            {
                // Call events to retrived appoint related
                // to selected doctor
                DoctorNameListBox.SelectedIndexChanged += GetAppointInfo;

                //**********************************************************
                //****    Get the selected items in the filter listviews ***
                //****   when the changes in the listviews are made    *****
                //**********************************************************

                // ------> Gender Filter List View
                GenderFilterListView.ItemChecked += GenderFilterListView_SelectedIndexChanged;

                // ------> Time Filter List View
                TimeFilterListView.ItemChecked += TimeFilterListView_SelectedIndexChanged;


                //**********************************************************
                //****   Trigger Filter Event Handler                  *****
                //****   when the changes in the listviews are made    *****
                //**********************************************************
                GenderFilterListView.ItemChecked += Filter;
                TimeFilterListView.ItemChecked += Filter;

            } else
            {
                DoctorNameListBox.SelectedIndexChanged -= GetAppointInfo;

                GenderFilterListView.ItemChecked -= GenderFilterListView_SelectedIndexChanged;
                TimeFilterListView.ItemChecked -= TimeFilterListView_SelectedIndexChanged;

                GenderFilterListView.ItemChecked -= Filter;
                TimeFilterListView.ItemChecked -= Filter;
            }
        }

        // Event to close form
        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method for populating the time list view
        //***** Item for times will be populate by the preset list of time
        private void PopulateTimeListView()
        {
            string[] time = {"9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM",
                              "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "1:00 PM",
                              "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM",
                              "4:00 PM", "4:30 PM", "5:00 PM", "5:30 PM"};

            foreach (string t in time)
            {
                TimeFilterListView.Items.Add(t);
            }

        }

        // Method for populating gender list view
        private void PopulateGenderListView()
        {
            // Retrive the avaiable gender from patient database by using context
            var patientGender = clinicCtx.Patients.Where(x => x.PatientsGender != null).Select(x => x.PatientsGender).Distinct();

            foreach (var g in patientGender)
            {
                GenderFilterListView.Items.Add(g);
            }
        }

        // Method for setting all the item in listview to be checked
        private void SetItemListCheck(ListView listViewName, string state)// 1st para: listview name
                                                                          // 2nd para: check state
        {
            switch (state)
            {
                case "check":
                    foreach (ListViewItem item in listViewName.Items)
                    {
                        item.Checked = true;
                    }
                    break;
                case "uncheck":
                    foreach (ListViewItem item in listViewName.Items)
                    {
                        item.Checked = false;
                    }
                    break;
            }
            
        }

        // Method to set up the list view header
        
        private void SetUpListViewHeader(ListView modifyingListView, string headerTitle) // 1st para: listview name
                                                                                         // 2nd para: name of the listview as header
        {
            modifyingListView.Columns.Add(headerTitle);
        }

        // Method to populate the doctor name into doctor listbox
        private void PopulateDoctorListBox()
        {
            // Get the doctor name from doctor entity by using context 
            var doctorName = (from d in clinicCtx.Doctors
                              where d.DoctorsName != null
                              select d.DoctorsName).Distinct();


            int totalDoctor = doctorName.Count(); // counter for the doctor as doctor stats

            TotalDoctorOutputLabel.Text = totalDoctor.ToString(); // populate the current available doctor

            foreach (var d in doctorName)
            {
                DoctorNameListBox.Items.Add(d);
            }

        }

        private void GetAppointInfo(object sender, EventArgs e)
        {
 
            string selectedDoctor = DoctorNameListBox.SelectedItem.ToString(); // Get the selected doctor from user

            // LINQ --> get the appointment related to the selected doctor
            // The needed information for the appointment:
            // 1. Appointments' Date
            // 2. Appointments' Time
            // 3. Patients' First Name
            // 4. Patients' Last Name
            // 5. Patients' Gender
            // 6. Patients' HealthNumnber
            var aptByDoctor = from ap in clinicCtx.Appointments
                                join d in clinicCtx.Doctors on ap.DoctorsId equals d.DoctorsId
                                join p in clinicCtx.Patients on ap.PatientsId equals p.PatientsId
                                where ap.DoctorsId == d.DoctorsId
                                && selectedDoctor == d.DoctorsName
                                select new
                                {
                                    ap.AppointmentsDate,
                                    ap.AppointmentsTime,
                                    ap.Patient.PatientsFirstName,
                                    ap.Patient.PatientsLastName,
                                    ap.Patient.PatientsGender,
                                    ap.Patient.HealthNumber
                                };

            // Populate the current patients on the list
            CurrentPatientOututLabel.Text = aptByDoctor.Count().ToString();

            // Populate the selected appointments from doctor name to the data grid view
            DoctorAppointmentGridView.DataSource = aptByDoctor.ToList();

            SetItemListCheck(GenderFilterListView, "check"); // Set the gender list view checked again
            SetItemListCheck(TimeFilterListView, "uncheck"); // Set the time list view unchecked again
           

        }

        // Method to get the checked item in the list view
        // Used mainly on getting the checked item for the filter listview
        // when the form load
        List<string> GetCheckFilterItem(ListView ListOfData)  // Parameter: the name of list view
        {
            List<string> checkItems = new List<string>();

            foreach (ListViewItem item in ListOfData.CheckedItems)
            {
                checkItems.Add(item.Text);
            }

            return checkItems; // return the list of item for purpose of filter
        }

        // Filter Event
        private void Filter(object sender, EventArgs e)
        {
            try
            {
                string selectedDoctor = DoctorNameListBox.SelectedItem.ToString(); // Get the selected doctor from user

                // LINQ --> get the appointment related to the selected doctor
                // The needed information for the appointment:
                // 1. Appointments' Date
                // 2. Appointments' Time
                // 3. Patients' First Name
                // 4. Patients' Last Name
                // 5. Patients' Gender
                // 6. Patients' HealthNumnber
                var aptByDoctor = from ap in clinicCtx.Appointments
                                  join d in clinicCtx.Doctors on ap.DoctorsId equals d.DoctorsId
                                  join p in clinicCtx.Patients on ap.PatientsId equals p.PatientsId
                                  where ap.DoctorsId == d.DoctorsId
                                  && selectedDoctor == d.DoctorsName
                                  select new
                                  {
                                      ap.AppointmentsDate,
                                      ap.AppointmentsTime,
                                      ap.Patient.PatientsFirstName,
                                      ap.Patient.PatientsLastName,
                                      ap.Patient.PatientsGender,
                                      ap.Patient.HealthNumber
                                  };

                // Condition:
                // There is checked item in both filter : TIME & GENDER
                // GENDER will be always checked when the form load
                if (checkedTime.Any() && checkedGender.Any())
                {
                    // Join the list of appointments from selected doctor with 2 list of filter items
                    var filterApt = from apt in aptByDoctor
                                    join g in checkedGender on apt.PatientsGender equals g
                                    join t in checkedTime on apt.AppointmentsTime equals t
                                    select new
                                    {
                                        apt.AppointmentsDate,
                                        apt.AppointmentsTime,
                                        apt.PatientsFirstName,
                                        apt.PatientsLastName,
                                        apt.PatientsGender,
                                        apt.HealthNumber
                                    };

                    // Repopulate the list
                    DoctorAppointmentGridView.DataSource = filterApt.ToList();

                    //Update the current patient in the list
                    CurrentPatientOututLabel.Text = filterApt.Count().ToString();
                }
                else if (!checkedTime.Any() && checkedGender.Any())  // When the user don't want to filter by TIME, only by GENDER
                {
                    // Join the list of appointments from selected doctor with filter gender list
                    // Because the user don't filter by time, we don't join the NULL checkedTime list
                    var filterApt = from apt in aptByDoctor
                                    join g in checkedGender on apt.PatientsGender equals g
                                    select new
                                    {
                                        apt.AppointmentsDate,
                                        apt.AppointmentsTime,
                                        apt.PatientsFirstName,
                                        apt.PatientsLastName,
                                        apt.PatientsGender,
                                        apt.HealthNumber
                                    };

                    // Repopulate the list
                    DoctorAppointmentGridView.DataSource = filterApt.ToList();

                    //Update the current patient in the list
                    CurrentPatientOututLabel.Text = filterApt.Count().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Please choose the doctor name for see his/her appoinments");
      
            }
        }
        

        #region EVENTS FOR GETTING THE CHECKED ITEMS FROM FILTER 
        // for GENDER 
        private void GenderFilterListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedGender.Clear(); // clear the list for next use
            checkedGender = GetCheckFilterItem(GenderFilterListView); // get the checked item by call pre-wrote method

            if(!checkedGender.Any())
            {
                MessageBox.Show("Gender must be at least one item selected");
                SetItemListCheck(GenderFilterListView, "check");
            }
        }
        
        // for TIME
        private void TimeFilterListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedTime.Clear(); // clear the list for next use
            checkedTime = GetCheckFilterItem(TimeFilterListView); // get the checked item by call pre-wrote method
        }
    #endregion

    }
}
