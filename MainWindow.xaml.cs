using PatientConsultationRecord.Patients;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PatientConsultationRecord
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Patients.PatientList listWindow = new Patients.PatientList();
            listWindow.Show();
            this.Close();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Patients.Patient_Information listWindow = new Patients.Patient_Information();
            listWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login main = new Login();
            main.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ChangePass main = new ChangePass();
            main.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddUser main = new AddUser();
            main.Show();
            this.Close();
        }
    }
}
