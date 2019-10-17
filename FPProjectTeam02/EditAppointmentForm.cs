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
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace FPProjectTeam02
{
    public partial class EditAppointmentForm : Form
    {
        string nameReg = @"^[a-zA-Z]+$"; // Regular Expression for letter only
        public EditAppointmentForm()
        {
            InitializeComponent();
        }

        private void EditAppointmentForm_Load(object sender, EventArgs e)
        {
            LoadingLabel.Visible = false; //----- hiding the top loading indicator
            ChangesSavedLabel.Visible = false; //--------hiding the user notifing label

            SetupPatientDataGridView(); //-------calling the method for setting up patient's data grid view
            SetUpEditAppointmentGridView(); //-------calling the method for setting up Appointment data grid view
            PatientDatagridViewLookup.SelectionChanged += LookUpAppointment; //-------calling lookUpAppointment event handler method
            ExitButton.Click += closeForm; //------- to close the form
        }

        private void closeForm(object sender, EventArgs e) //-- method to close the current form
        {
            this.Close();
        }



        private void EditAppointment() //--method to edit appointment table and save changes to it
        {
            try
            {
                using (var editCtx = new ClinicContext())
                {
                    int pId = Convert.ToInt32(PatientIdTextBox.Text); //---- as in our database the id for apt / patient / doctor are same in all the tables so instead od defining 3 id's m just defining one as its the same
                    Patients patientsToEdit = editCtx.Patients.Find(pId);
                    Appointments apptToEdit = editCtx.Appointments.Find(pId);

                    // ------ comparing the values from the data grid 
                    if (patientsToEdit.PatientsFirstName != AppointmentGridView.Rows[0].Cells[1].Value.ToString() || patientsToEdit.PatientsLastName != AppointmentGridView.Rows[0].Cells[2].Value.ToString() && apptToEdit.AppointmentsTime == AppointmentGridView.Rows[0].Cells[4].Value.ToString() && apptToEdit.AppointmentsDate == AppointmentGridView.Rows[0].Cells[3].Value.ToString())
                    {
                        //------- updating the values on to the database
                        patientsToEdit.PatientsFirstName = AppointmentGridView.Rows[0].Cells[1].Value.ToString();
                        patientsToEdit.PatientsLastName = AppointmentGridView.Rows[0].Cells[2].Value.ToString();
                        editCtx.SaveChanges();

                        //label updated ChangesSaved
                        ChangesSavedLabel.Visible = true;
                        ChangesSavedLabel.Text = "Your Changes were successfully saved!";
                    }

                    else if (IsAppointment() == 0)
                    {
                        apptToEdit.AppointmentsTime = AppointmentGridView.Rows[0].Cells[4].Value.ToString();
                        apptToEdit.AppointmentsDate = AppointmentGridView.Rows[0].Cells[3].Value.ToString();

                        //------- updating the values on to the database
                        patientsToEdit.PatientsFirstName = AppointmentGridView.Rows[0].Cells[1].Value.ToString();
                        patientsToEdit.PatientsLastName = AppointmentGridView.Rows[0].Cells[2].Value.ToString();
                        editCtx.SaveChanges();

                        //label updated ChangesSaved
                        ChangesSavedLabel.Visible = true;
                        ChangesSavedLabel.Text = "Your Changes were successfully saved!";
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Please enter id/lastname/firstname");
            }
        }

        private int IsAppointment() // ------- this method is to check that the new date and time the user is setting doesn't exit in the database.
        {

            int c = 0;
            try
            {
                using (var ctx = new ClinicContext())
                {

                    string appointmentTime = AppointmentGridView.Rows[0].Cells[4].Value.ToString(); //geting the appointment time and date
                    string appointmentDate = AppointmentGridView.Rows[0].Cells[3].Value.ToString();
                    //query to check if doctor is available on the entered date and time
                    var appointment = from doct in ctx.Doctors
                                      from appt in ctx.Appointments
                                      where appt.DoctorsId == doct.DoctorsId
                                         && appointmentDate == appt.AppointmentsDate
                                            && appointmentTime == appt.AppointmentsTime
                                      select appt;

                    foreach (var item in appointment)
                    {
                        MessageBox.Show("Sorry, Appointment is not available for this date and time!");
                        c = 1;
                        ChangesSavedLabel.Text = "Please check the appointment date and time";
                        break;

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("There is appointment to be edited");
            }

            return c;
        }

        private void CancelAppointment() //0-------method to cancel an appointment
        {
            try
            {


                int currentAppointmentId = Convert.ToInt32(PatientDatagridViewLookup.Rows[0].Cells[0].Value);

                using (ClinicContext clinicCtx = new ClinicContext())
                {


                    Appointments appointment = (from a in clinicCtx.Appointments
                                                where a.AppointmentId == currentAppointmentId
                                                select a).FirstOrDefault();
                    clinicCtx.Appointments.Remove(appointment);
                    clinicCtx.SaveChanges();

                    ChangesSavedLabel.Visible = true;
                    ChangesSavedLabel.Text = "The Appointment was successfully Removed!";
                    CancelAppointmentButton.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("No appointment to be cancelled");
            }

        }


        private void LookUpPatient()        //------- method to populate the datagrid view with the patients info
        {
            PatientDatagridViewLookup.Rows.Clear(); //----- clearing data grid view as items will be added to it

            string pLastName = PatientLastNameTextBox.Text;
            string pFirstName = PatientFirstNameTextBox.Text;

            int pId = 0;
            if (PatientIdTextBox.Text != "")
            {
                try
                {
                    pId = Convert.ToInt32(PatientIdTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("ID can only a number");
                }
            }


            if (pLastName != "" || pFirstName != "" || pId > 0)
            {
                if ((Regex.IsMatch(pLastName, nameReg) || pLastName == "") && (Regex.IsMatch(pFirstName, nameReg) || pFirstName == ""))
                {
                    LoadingLabel.Visible = true; // showing the loading label on top to tell the customer that the page is processing
                    using (ClinicContext clinicCtx = new ClinicContext())
                    {

                        var lookedPatients = (from p in clinicCtx.Patients
                                              from apt in clinicCtx.Appointments
                                              where //p.PatientsId == apt.PatientsId 
                                               pLastName == p.PatientsLastName
                                              || pFirstName == p.PatientsFirstName
                                              || (pId == p.PatientsId && p.PatientsId == apt.PatientsId)
                                              group p by apt.PatientsId into groupP

                                              from gp in groupP
                                              where gp.PatientsLastName != null
                                              select new
                                              {
                                                  PatientID = gp.PatientsId,
                                                  PatientFirstName = gp.PatientsFirstName,
                                                  PatientLastName = gp.PatientsLastName,
                                                  PatientsPhone = gp.PatientsPhone,
                                                  PatientsDOB = gp.PatientsBirthDate,
                                                  PatientsGender = gp.PatientsGender
                                              }).Distinct();

                        foreach (var p in lookedPatients) //---- adding the result from the query to the patient info data grid view
                        {
                            PatientDatagridViewLookup.Rows.Add(
                                    p.PatientID,
                                    p.PatientFirstName,
                                    p.PatientLastName,
                                    p.PatientsGender,
                                    p.PatientsDOB,
                                    p.PatientsPhone
                                );
                        }

                        int numRows = PatientDatagridViewLookup.Rows.Count; //counting the number of rows in the patient table so that i can check if the data grid is empty or not

                        if (numRows == 0)
                        {
                            MessageBox.Show("No Appointments found For the Desired Patient");
                            ChangesSavedLabel.Visible = true;
                            ChangesSavedLabel.Text = "No appointment records found for the desired Patient";
                            AppointmentGridView.Rows.Clear();
                        }
                    }
                    LoadingLabel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Name cannot includes numbers");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Input, as no records were found for that patient.");
            }
        }

        private void SetUpEditAppointmentGridView() //----- setting up the dataGrid for Appointments
        {
            DataGridViewTextBoxColumn[] c = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Appointment ID" },
                new DataGridViewTextBoxColumn { Name = "Patient First Name" },
                new DataGridViewTextBoxColumn { Name = "Patient Last Name" },
                new DataGridViewTextBoxColumn { Name = "Appointment Date" },
                new DataGridViewTextBoxColumn { Name = "Appointment Time" }

            };
            AppointmentGridView.Columns.AddRange(c);
        }


        private void SetupPatientDataGridView()   //setting up the datagrid View for patients
        {
            PatientDatagridViewLookup.MultiSelect = false;

            //Setup the DataGridView Columns
            PatientDatagridViewLookup.ColumnCount = 6;
            PatientDatagridViewLookup.Columns[0].Name = "PatientId";
            PatientDatagridViewLookup.Columns[1].Name = "First Name";
            PatientDatagridViewLookup.Columns[2].Name = "Last Name";
            PatientDatagridViewLookup.Columns[3].Name = "Gender";
            PatientDatagridViewLookup.Columns[4].Name = "Date of birth";
            PatientDatagridViewLookup.Columns[5].Name = "Phone";
        }


        private void LookUpAppointment(object sender, EventArgs e) //------ this method populates the lower dataGrid with the appointment details of the selected patient 
        {
            CancelAppointmentButton.Enabled = true; //---enabling the button as it turns off after cancelation of appointment.
            AppointmentGridView.Rows.Clear(); //--- clearing the rows on start of the method as dont want to repeat data on click of button everytime.

            int selectedRow = Convert.ToInt32(PatientDatagridViewLookup.CurrentCell.RowIndex);
            int currentPatientsId = Convert.ToInt32(PatientDatagridViewLookup.Rows[selectedRow].Cells[0].Value);
            LoadingLabel.Visible = true;
            using (ClinicContext clinicCtx = new ClinicContext())
            {

                var lookedAppointments = from p in clinicCtx.Patients
                                         from apt in clinicCtx.Appointments
                                         from doc in clinicCtx.Doctors
                                         where p.PatientsId == apt.PatientsId
                                         && currentPatientsId == apt.PatientsId && doc.DoctorsId == apt.DoctorsId
                                         select new                 /// linq query to get appointment id ,patients name, and aappointment details.
                                         {
                                             AptID = apt.AppointmentId,
                                             PatientFirstName = p.PatientsFirstName,
                                             PatientLastName = p.PatientsLastName,
                                             ApptDate = apt.AppointmentsDate,
                                             ApptTime = apt.AppointmentsTime

                                         };
                foreach (var p in lookedAppointments)   //adding the result from query to the data grid view.
                {
                    AppointmentGridView.Rows.Add(
                            p.AptID,
                            p.PatientFirstName,
                            p.PatientLastName,
                            p.ApptDate,
                            p.ApptTime
                        );
                }



            }
            LoadingLabel.Visible = false;


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LoadingLabel.Visible = true;
            LookUpPatient(); // calling look up patient method 
        }

        private void EditAppointmentButton_Click(object sender, EventArgs e)
        {
            EditAppointment(); // calling edit appointment method
        }


        private void CancelAppointmentButton_Click_1(object sender, EventArgs e)
        {
            CancelAppointment(); // calling cancel appointment method
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
