using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientConsultationRecord.Models
{
    public class Consultation
    {
        public Guid? ConsultationID { get; set; }
        public Guid? PatientID { get; set; }
        public string Symptoms { get; set; }
        public string Results { get; set; }
        public string Descriptions { get; set; }
        public string Medication { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
