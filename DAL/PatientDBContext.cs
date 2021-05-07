using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientConsultationRecord.DAL
{
    public class PatientDBContext : DbContext
    {

        public PatientDBContext() : base("myConnectionString")
        {
            // Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Models.Consultation> Consultations { get; set; }
        public DbSet<Models.Patient> Patients { get; set; }
        public DbSet<Models.User> Users { get; set; }
    }
}
