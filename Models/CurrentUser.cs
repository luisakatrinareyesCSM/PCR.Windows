using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientConsultationRecord.Models
{
   public static class  CurrentUser 
    {
        public static Guid? UserID { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Sex { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }

    }
}
