using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPProjectTeam02.Entities
{
    public class Appointments
    {
       [Key]
       
        public int AppointmentId { get; set; }

        public string AppointmentsDate { get; set; }

        public string AppointmentsTime { get; set; }

       public int DoctorsId { get; set; }

        public int PatientsId { get; set; }

        [ForeignKey("DoctorsId")]
        public Doctors Doctor { get; set; }

        [ForeignKey("PatientsId")]
        public Patients Patient { get; set; }
        
    }
}
