using PatientConsultationRecord.DAL;
using PatientConsultationRecord.Helpers;
using PatientConsultationRecord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientConsultationRecord.BLL
{
    public static class PatientBLL
    {
        private static PatientDBContext db = new PatientDBContext();

        public static Paged<Models.Patient> Search(int pageIndex = 1, int pageSize = 5, string sortBy = "last name", string sortOrder = "asc", string keyword = "")
        {
            IQueryable<Patient> allPatients = (IQueryable<Patient>)db.Patients;
            Paged<Models.Patient> patients = new Paged<Patient>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allPatients = allPatients.Where(e => e.FirstName.Contains(keyword) || e.LastName.Contains(keyword));
            }

            var queryCount = allPatients.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)((queryCount) / pageSize));
            if ((queryCount % pageSize) > 0)
            { pageCount += 1; }

            if (sortBy.ToLower() == "first name" && sortOrder.ToLower() == "asc")
            {
                patients.Items = allPatients.OrderBy(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "first name" && sortOrder.ToLower() == "desc")
            {
                patients.Items = allPatients.OrderByDescending(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "last name" && sortOrder.ToLower() == "asc")
            {
                patients.Items = allPatients.OrderBy(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                patients.Items = allPatients.OrderByDescending(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }

            patients.PageCount = pageCount;
            patients.PageIndex = pageIndex;
            patients.PageSize = pageSize;
            patients.QueryCount = queryCount;

            return patients;

        }

        public static Helpers.Operation Add(Models.Patient patient)
        {
            try
            {
                db.Patients.Add(patient);
                db.SaveChanges();

                return new Helpers.Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = patient.PatientID
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
