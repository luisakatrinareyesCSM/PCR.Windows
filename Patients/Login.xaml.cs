using PatientConsultationRecord.BLL;
using PatientConsultationRecord.Models;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var op = UserBLL.Login(txtUser.Text, txtPass.Password);

            if (op.Code == "200")
            {

                var user = UserBLL.GetById(op.ReferenceId);
                CurrentUser.UserID = user.UserID;
                CurrentUser.FirstName = user.FirstName;
                CurrentUser.LastName = user.LastName;
                CurrentUser.Sex = user.Sex;
                CurrentUser.UserName = user.UserName;
                CurrentUser.Password = user.Password;
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
