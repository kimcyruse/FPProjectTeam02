using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPProjectTeam02.Entities
{
    public class ClinicContext:DbContext
    {
        public virtual DbSet<Appointments> Appointments { get; set; }

        public virtual DbSet<Doctors> Doctors { get; set; }

        public virtual DbSet<Patients> Patients { get; set; }

    }
}
