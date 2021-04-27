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
    public class UserBLL
    {

        private static PatientDBContext db = new PatientDBContext();

        public static Operation Login(string username = "", string password = "")
        {
            if (string.IsNullOrEmpty(username))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            if (string.IsNullOrEmpty(password))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            try
            {
                User user = db.Users.FirstOrDefault(e => e.UserName.ToLower() == username.ToLower());

                if (user == null)
                {
                    return new Operation()
                    {
                        Code = "500",
                        Message = "Invalid Login"
                    };
                }

                if (password == user.Password)
                {
                    return new Operation()
                    {
                        Code = "200",
                        Message = "Successful Login",
                        ReferenceId = user.UserID
                    };
                }

                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }
    }
}
