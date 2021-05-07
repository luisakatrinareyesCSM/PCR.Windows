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
        public static User GetById(Guid? id)
        {
            return db.Users.FirstOrDefault(e => e.UserID == id);
        }

        public static Operation Add(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = user.UserID
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

        public static Operation Update(User newRecord)
        {
            try
            {
                User oldRecord = db.Users.FirstOrDefault(e => e.UserID == newRecord.UserID  );

                if (oldRecord != null)
                {


                
                    oldRecord.Password = newRecord.Password;





                    db.SaveChanges();

                    return new Operation()
                    {
                        Code = "200",
                        Message = "OK"
                    };
                }


                return new Operation()
                {
                    Code = "500",
                    Message = "Not found"
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



    

