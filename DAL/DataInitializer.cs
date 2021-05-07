using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PatientConsultationRecord.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<PatientDBContext>
    {
        protected override void Seed(PatientDBContext context)
        {
            context.Users.Add(new Models.User()
            {
                FirstName = "Joy",
                LastName = "Flores",
                Password = "admin",
                UserName = "admin",
                Sex = "male",
                UserID = Guid.NewGuid()
                
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063561"),     
                FirstName = "Lolo",
                LastName = "Mo",
                Sex = "Male",
                Birthdate = DateTime.Parse("11/13/1920"),
                Birthplace = "#757 Pantalan Luma, Orani, Bataan"
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("17743b06-278d-4343-9e8a-dfe9df79c6ab"),
                FirstName = "mama",
                LastName = "kikay",
                Sex = "female",
                Birthdate = DateTime.Parse("11/12/1920"),
                Birthplace = "#7588 Pantalan Luma, Orani, Bataan"
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("a42c1c58-52e2-44bc-be52-8311eaf5d057"),
                FirstName = "papa",
                LastName = "kiko",
                Sex = "Male",
                Birthdate = DateTime.Parse("11/12/1920"),
                Birthplace = "#7589 Pantalan Luma, Orani, Bataan"
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("dea59723-8b7f-4c6b-acd9-b56dfb8fcf21"),
                FirstName = "robert",
                LastName = "magkalas",
                Sex = "Male",
                Birthdate = DateTime.Parse("11/12/1920"),
                Birthplace = "#7590 Pantalan Luma, Orani, Bataan"
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("6f6c87cd-ff59-4045-be9f-deebffda94c7"),
                FirstName = "janice",
                LastName = "lopez",
                Sex = "Female",
                Birthdate = DateTime.Parse("11/12/1920"),
                Birthplace = "#7591 Pantalan Luma, Orani, Bataan"
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("a73beb49-1d73-481c-995b-550b9f53b7b3"),
                FirstName = "Angel",
                LastName = "santiago",
                Sex = "Female",
                Birthdate = DateTime.Parse("11/12/1920"),
                Birthplace = "#7591 Pantalan Luma, Orani, Bataan"
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("c1566b09-a3e9-47e3-a5b9-d7f8657c807a"),
                FirstName = "kapiatn",
                LastName = "henry",
                Sex = "Male",
                Birthdate = DateTime.Parse("11/12/1920"),
                Birthplace = "#7593 Pantalan Luma, Orani, Bataan"
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("23f7b1cf-dd98-4627-95ef-7bbfd4d19e7c"),
                FirstName = "clark",
                LastName = "david",
                Sex = "Male",
                Birthdate = DateTime.Parse("11/12/1920"),
                Birthplace = "#7592 Pantalan Luma, Orani, Bataan"
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("68f055e2-064d-4117-9ce2-b398ead781fe"),
                FirstName = "Casupanan",
                LastName = "Clark",
                Sex = "Male",
                Birthdate = DateTime.Parse("11/12/1920"),
                Birthplace = "#7594 Pantalan Luma, Orani, Bataan"
            });

            context.Patients.Add(new Models.Patient()
            {
                PatientID = Guid.Parse("7cc09a86-e52b-48ab-b8cc-2bc2499df806"),
                FirstName = "john",
                LastName = "Cedric",
                Sex = "Male",
                Birthdate = DateTime.Parse("11/12/1920"),
                Birthplace = "#7595 Pantalan Luma, Orani, Bataan"
            });

                

            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be84"),
                Symptoms = "Lagnat,Ubo,Sipon",
                Results = "Covid",
                Descriptions = "Wag kang umubo",
                Medication = "Damo at Bioflu",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063561")
            });

            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be83"),
                Symptoms = "Kabobohan",
                Results = "ewan",
                Descriptions = "123",
                Medication = "456",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063561")
            });

            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be82"),
                Symptoms = "Wala dyan",
                Results = "ewan",
                Descriptions = "123",
                Medication = "456",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063562")
            });

            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be21"),
                Symptoms = "Wala dyan",
                Results = "ewan",
                Descriptions = "123",
                Medication = "454",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("dea59723-8b7f-4c6b-acd9-b56dfb8fcf21")
            });

            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be22"),
                Symptoms = "Wala dyan",
                Results = "ewan",
                Descriptions = "123",
                Medication = "455",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("6f6c87cd-ff59-4045-be9f-deebffda94c7")
            });

            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be52"),
                Symptoms = "Wala dyan",
                Results = "ewan",
                Descriptions = "123",
                Medication = "456",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("a73beb49-1d73-481c-995b-550b9f53b7b3")
            });

            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be62"),
                Symptoms = "Wala dyan",
                Results = "ewan",
                Descriptions = "123",
                Medication = "457",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("c1566b09-a3e9-47e3-a5b9-d7f8657c807a")
            });

            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be81"),
                Symptoms = "Wala dyan",
                Results = "ewan",
                Descriptions = "123",
                Medication = "458",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("23f7b1cf-dd98-4627-95ef-7bbfd4d19e7c")
            });


            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be99"),
                Symptoms = "Wala dyan",
                Results = "ewan",
                Descriptions = "123",
                Medication = "459",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("68f055e2-064d-4117-9ce2-b398ead781fe")
            });

            context.Consultations.Add(new Models.Consultation()
            {
                ConsultationID = Guid.Parse("51fd8cda-4c6c-4a8a-8ad3-201c80a3be87"),
                Symptoms = "Wala dyan",
                Results = "ewan",
                Descriptions = "123",
                Medication = "459",
                CreatedAt = DateTime.UtcNow,
                PatientID = Guid.Parse("7cc09a86-e52b-48ab-b8cc-2bc2499df806")
            });


        }
    }
}
