using PatientConsultationRecord.BLL;
using PatientConsultationRecord.Helpers;
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

namespace PatientConsultationRecord
{
    /// <summary>
    /// Interaction logic for ChangePass.xaml
    /// </summary>
    public partial class ChangePass : Window
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (CurrentUser.Password == txtCurrent.Text)
            {
                var op = UserBLL.Update(new User()
                {
                    UserID = CurrentUser.UserID,
                    Password = txtPass.Text,
                    FirstName = CurrentUser.FirstName,
                    LastName = CurrentUser.LastName,
                    Sex = CurrentUser.Sex,
                    UserName = CurrentUser.UserName,


                });
                if (op.Code != "200")
                {
                    MessageBox.Show("Error : " + op.Message);
                }
                else
                {
                    MessageBox.Show("Password is successfully updated");
                }

                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            


        }
        }
    }
}
    

