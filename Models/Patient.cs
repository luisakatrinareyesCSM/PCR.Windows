using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientConsultationRecord.Models
{
    public class Patient
    {
        public Guid? PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public string Birthplace { get; set; }
    }
}
