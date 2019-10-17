using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPProjectTeam02.Entities
{
    public class CSVParser
    {
        List<string> fileContents = new List<string>(); // List of string to collect each line in the CSV file

        //List of parsed patients
        public List<Patients> patientList = new List<Patients>(); 

        // List of parsed doctor
        public List<Doctors> doctorList = new List<Doctors>();

        // List of parsed appointments
        public List<Appointments> appointmentList = new List<Appointments>();

        OpenFileDialog CSVOpenDialog = new OpenFileDialog(); // CSV File Open Dialog

        // Method to ask for CSV file
        // then add each line into the list of string for further use
        public void LoadData()
        {
            CSVOpenDialog.ShowDialog();
            StreamReader inputFile = File.OpenText(CSVOpenDialog.FileName);
            
            while(!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                fileContents.Add(line);
            }

        }


        // Method to parse the data in the fileContents collection into
        // proper entity object
        public void ParseData()
        {
            LoadData(); // Call the method to ask for CSV file

            using (ClinicContext ctx = new ClinicContext())
            {
                foreach (string row in fileContents)
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        var cells = row.Split(','); // split each row by the comma

                        //Instantiate the patient object for each patient
                        //in order to add the DBSet
                        Patients p = new Patients();
                        p.PatientsLastName = cells[0].Trim();
                        p.PatientsFirstName = cells[1].Trim();
                        p.PatientsGender = cells[2].Trim();
                        p.PatientsBirthDate = cells[3].Trim();
                        p.PatientsAddress = cells[4].Trim();
                        p.PatientsPostalCode = cells[5].Trim();
                        p.PatientsCity = cells[6].Trim();
                        p.PatientsProvince = cells[7].Trim();
                        p.PatientsPhone = cells[8].Trim();
                        p.HealthNumber = (cells[9]).Trim();

                        patientList.Add(p); // Add patient to patientList for further use

                        ctx.Patients.Add(p); // Add patient to Dbset by context

                        //Instantiate the Doctor object for each patient
                        //in order to add the DBSet
                        Doctors d = new Doctors();
                        d.DoctorsName = cells[10].Trim();
                        d.DoctorsPhone = cells[11].Trim();

                        doctorList.Add(d); // Add doctor to docterList for further use

                        ctx.Doctors.Add(d); // Add Doctor to Dbset by context

                        //Instantiate the appointment object for each patient
                        //in order to add the DBSet
                        Appointments appt = new Appointments
                        {
                            PatientsId = p.PatientsId,
                            DoctorsId = d.DoctorsId,
                            AppointmentsDate = cells[12].Trim(),
                            AppointmentsTime = cells[13].Trim()
                        };
                        
                        appointmentList.Add(appt); // Add appointment to appoinmentList for further use
                        ctx.Appointments.Add(appt); // Add appointmnets to Dbset by context

                        ctx.SaveChanges(); // Save all the changes in the context

                    }
                }
            }
            
        }
    }
}

