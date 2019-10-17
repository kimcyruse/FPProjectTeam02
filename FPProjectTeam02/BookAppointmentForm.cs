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

    public partial class BookAppointmentForm : Form
    {
        ClinicContext ctx;
        int appointmentId;

        //Create a new Appointment in Runtime
        Appointments newAppointment = new Appointments();
        Patients newPatient = new Patients();
        Doctors newDoctor = new Doctors();

        string nameReg = @"^[a-zA-Z]+$"; // Regular Expression for letter only

        public BookAppointmentForm()
        {
            InitializeComponent();
        }

        private void BookAppointmentForm_Load(object sender, EventArgs e)
        {
            //create new context object when the form loads
            ctx = new ClinicContext();
            ctx.Patients.Add(newPatient);
            ctx.Doctors.Add(newDoctor);

            //turn event handler on
            BookButton.Click += CreateNewAppointment;
            ExitButton.Click += CloseForm;

            //change combobox style to make it read only
            SelectDoctorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AppointmentTimeBoxcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //function to check whether the user's desierd appointment is available or not
        private int IsAppointment()
        {

            string appointmentDate = AppointmentDateTimePicker1.Text;
            string appointmentTime = AppointmentTimeBoxcomboBox.Text;
            //query to check if doctor is available on the entered date and time
            var appointment = from doct in ctx.Doctors
                              from appt in ctx.Appointments
                              where appt.DoctorsId == doct.DoctorsId
                                  && appointmentDate == appt.AppointmentsDate
                                  && appointmentTime == appt.AppointmentsTime
                              select appt;
            int c = 0;
            foreach (var item in appointment)
            {
                MessageBox.Show("Sorry, Appointment is not available for this date and time!");
                c = 1;

                break;

            }
            return c;



        }



        //event handler to create a new appointment and  push data from BookAppointment into database
        private void CreateNewAppointment(object sender, EventArgs e)
        {


            if (IsAppointment() == 0)
            {
                try
                {
                    string pLastName = PatientLastNameTextBox.Text;
                    string pFName = PatientFirstNameTextBox.Text;
                    string dName = SelectDoctorComboBox.SelectedItem.ToString();
                    string appointmentDate = AppointmentDateTimePicker1.Text;
                    string appointmentTime = AppointmentTimeBoxcomboBox.Text;

                    if (pLastName != "" && pFName != "")
                    {
                        if (Regex.IsMatch(pLastName, nameReg) && Regex.IsMatch(pFName, nameReg)) // Check the user input pattern
                        {
                            //Add the details to the appointment

                            //using linq to get PatientsId from its last name or first name
                            var patientName = from p in ctx.Patients
                                              where pLastName == p.PatientsLastName
                                                  && pFName == p.PatientsFirstName
                                              select p.PatientsId;
                            foreach (var p in patientName)
                            {
                                newAppointment.PatientsId = p;
                            }

                            newAppointment.AppointmentsDate = AppointmentDateTimePicker1.Text;
                            newAppointment.AppointmentsTime = AppointmentTimeBoxcomboBox.Text;

                            // using linq to get doctorsId from its name
                            var doctor = from d in ctx.Doctors
                                         where dName == d.DoctorsName
                                         select d.DoctorsId;
                            foreach (var d in doctor)
                            {
                                newAppointment.DoctorsId = d;
                            }

                            //Add the Appointment to the DBSet
                            ctx.Appointments.Add(newAppointment);
                            //Save the Changes
                            ctx.SaveChanges();
                            //Pull the new OrderId
                            this.appointmentId = Convert.ToInt32(newAppointment.AppointmentId);
                            //Prompt the users
                            MessageBox.Show("Appointment " + this.appointmentId + " has been bookeked on "
                                            + appointmentDate + " at " + appointmentTime
                                            + " with Dr. " + SelectDoctorComboBox.Text);


                            //Disable the Book Button so some tool doesnt keep clicking on it..
                            BookButton.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("The input name is not correct, only character is acceptable");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The name cannot be blank");
                    }
                }

                catch (Exception ctxOr)
                {
                    MessageBox.Show("The Appointment could not be booked - Please input the patient, select the doctor and appointment time");
                    Console.WriteLine(ctxOr.StackTrace);
                }
            }
        }





        // event handler to close the form 
        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
