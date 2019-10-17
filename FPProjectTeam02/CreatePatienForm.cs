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
using System.Text.RegularExpressions;

namespace FPProjectTeam02
{
    public partial class CreatePatienForm : Form
    {
        List<Patients> newPatient = new List<Patients>();
        CSVParser myParser = new CSVParser();
        int parsedPatientID;

        string letterOnly = @"^[a-zA-Z]+$"; // Regular Expression for letter only
        string letterAndNumbers = @"^[a-zA-Z0-9\s]+$"; // Regular Expression for letter & number only
        string numberOnly = @"[0-9]"; // Regular Expression for number only

        public CreatePatienForm()
        {
            InitializeComponent();
        }

        private void CreatePatienForm_Load(object sender, EventArgs e)
        {
            CreateButton.Click += CreatenewPatients; //turn event handler on
            AppointmentButton.Click += LoadForm; //turn event handler on
            PatientIdTextBox.ReadOnly = true;   //setting property od patientsIdTextBox Read-only
            PatientsGenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;//setting property od patientsGenderComboBox Read-only
        }

        //add data into patients table from CreatePatientForm
        void CreatenewPatients(object sender, EventArgs e)
        {
            using (ClinicContext ctx = new ClinicContext())
            {
                try
                {
                    if (PatientLastNameTextBox.Text != "" && PatientFirstNameTextBox.Text != "" &&
                        PatientAddressTextBox.Text != "" && PatientCityTextBox.Text != "" &&
                        PatientPostalCodeTextBox.Text != "" && PatientsProvinceTextBox.Text != "" &&
                        PatientsGenderComboBox.Text != "" && PatientPhoneTextBox.Text != "" &&
                        PatientBirthDateMaskedTextBox.Text != "" && HealthNumberTextBox.Text != "")
                    {
                        // Condition statements to match the user input for the regular expression
                        //-------- Letter only
                        if (Regex.IsMatch(PatientLastNameTextBox.Text, letterOnly) &&
                            Regex.IsMatch(PatientFirstNameTextBox.Text, letterOnly) &&
                            Regex.IsMatch(PatientCityTextBox.Text, letterOnly) &&
                            Regex.IsMatch(PatientsProvinceTextBox.Text, letterOnly))
                        {
                            // ------------ Letter & Number
                            if (Regex.IsMatch(PatientAddressTextBox.Text, letterAndNumbers) &&
                                Regex.IsMatch(PatientPostalCodeTextBox.Text, letterAndNumbers))
                            {
                                // ------- number only
                                if (Regex.IsMatch(PatientPhoneTextBox.Text, numberOnly) &&
                                   Regex.IsMatch(HealthNumberTextBox.Text, numberOnly) &&
                                   Regex.IsMatch(PatientBirthDateMaskedTextBox.Text, numberOnly))
                                {
                                    // Create a new Patients in runtime
                                    Patients patient = new Patients();

                                    // Insert patients data into patient table
                                    patient.PatientsLastName = PatientLastNameTextBox.Text;
                                    patient.PatientsFirstName = PatientFirstNameTextBox.Text;
                                    patient.PatientsAddress = PatientAddressTextBox.Text;
                                    patient.PatientsCity = PatientCityTextBox.Text;
                                    patient.PatientsPostalCode = PatientPostalCodeTextBox.Text;
                                    patient.PatientsProvince = PatientsProvinceTextBox.Text;
                                    patient.PatientsGender = PatientsGenderComboBox.Text;
                                    patient.PatientsPhone = PatientPhoneTextBox.Text;
                                    patient.PatientsBirthDate = PatientBirthDateMaskedTextBox.Text;
                                    patient.HealthNumber = HealthNumberTextBox.Text;

                                    // Add patient to DBSet
                                    ctx.Patients.Add(patient);
                                    ctx.SaveChanges();//save the changes

                                    // Pull in new PatientsId
                                    this.parsedPatientID = Convert.ToInt32(patient.PatientsId);
                                    this.PatientIdTextBox.Text = Convert.ToString(this.parsedPatientID);

                                    //Disable the Create Button so some tool doesnt keep clicking on it..
                                    CreateButton.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Can only number  for name of birthday/ healthnumber/ phonenumber");

                                }
                            }
                            else
                            {
                                MessageBox.Show("Can only use letter and number  for name of address/ postal code");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Can only use letter for name of patients/city/province");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Create Patient From must be fully filled");
                    }
                }
                catch (Exception ctxEx)
                {
                    MessageBox.Show("Unable to add the Patient");
                    Console.WriteLine(ctxEx.StackTrace);
                }

            }
        }

        //event handler to load BookAppointment Form
        private void LoadForm(object sender, EventArgs e)
        {
            if (sender == AppointmentButton)
            {
                Form Appointment = new BookAppointmentForm();
                Appointment.Show();
            }
        }


        //event handler to close CreayePatientsForm
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
