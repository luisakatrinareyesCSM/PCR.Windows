using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientConsultationRecord.Models
{
    public class User
    {
        public Guid? UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
