using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPProjectTeam02.Entities
{
    public class Patients
    {
        [Key]
        public int PatientsId { get; set; }

        public string PatientsLastName { get; set; }

        public string PatientsFirstName { get; set; }

        public string PatientsGender { get; set; }

        public string PatientsAddress { get; set; }

        public string PatientsCity { get; set; }

        public string PatientsPostalCode { get; set; }

        public string PatientsProvince { get; set; }

        public string PatientsPhone { get; set; }

        public string PatientsBirthDate { get; set; }

        public string HealthNumber { get; set; }

        public virtual ICollection<Appointments> AppointmentsId { get; set; }= new HashSet<Appointments>();


    }
}
