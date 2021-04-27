using PatientConsultationRecord.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientConsultationRecord.BLL
{
    public static class ConsultationBLL
    {
        private static PatientDBContext db = new PatientDBContext();
         
        public static List<PatientConsultationRecord.Models.Consultation> List(Guid? patientID)
        {
            return db.Consultations.Where(e => e.PatientID == patientID).ToList();

        }

        public static Helpers.Operation Add(Models.Consultation consultation)
        {
            try
            {
                db.Consultations.Add(consultation);
                db.SaveChanges();

                return new Helpers.Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = consultation.ConsultationID
                };
            }
            catch (Exception e)
            {
                return new Helpers.Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }



    }
}
