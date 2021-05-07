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
    /// Interaction logic for addpatient.xaml
    /// </summary>
    public partial class addpatient : Window
    {
        public addpatient()
        {
            InitializeComponent();
            txtSex.ItemsSource = new List<string> { "Male", "Female" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string bdate = txtMonth.Text + "/" + txtDay.Text +  "/" + txtyear.Text;
            string gender = txtSex.SelectedItem.ToString();
            var op = BLL.PatientBLL.Add(new Models.Patient()
            {
                PatientID = Guid.NewGuid(),
                FirstName = txtFName.Text,
                LastName = txtLName.Text,
                Birthdate = DateTime.Parse(bdate),
                Birthplace = txtBirthplace.Text,
                Sex = gender
            });


            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("Patient is successfully added");
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
