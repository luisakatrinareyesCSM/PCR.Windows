using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PatientConsultationRecord.Patients
{
    /// <summary>
    /// Interaction logic for addCosultation.xaml
    /// </summary>
    public partial class addCosultation : Window
    {
        private Guid? patId;
        public addCosultation(Models.Patient consultation)
        {
            InitializeComponent();

            patId = consultation.PatientID;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var op = BLL.ConsultationBLL.Add(new Models.Consultation()
            {
                CreatedAt = DateTime.UtcNow,
                ConsultationID = Guid.NewGuid(),
                Descriptions = txtDesc.Text,
                Medication = txtMed.Text,
                PatientID = patId,
                Results = txtRes.Text,
                Symptoms = txtSymp.Text

            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("Consultation is successfully added");
                this.Close();
            }
        }
    }
}
