using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPProjectTeam02.Entities
{
    public class Doctors
    {
        [Key]
        public int DoctorsId { get; set; }

        public string DoctorsName { get; set; }

        public string DoctorsPhone { get; set; }

        public virtual ICollection<Appointments> AppointmentsId { get; set; }= new HashSet<Appointments>();
    }
}
