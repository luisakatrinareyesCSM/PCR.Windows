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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
            cboGender.ItemsSource = new List<string>() { "Male", "Female" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var op = BLL.UserBLL.Add(new Models.User()
            {
                
                UserID = Guid.NewGuid(),
                FirstName =txtFname.Text,
                LastName = txtLname.Text,
                UserName = txtUname.Text,
                Password = txtPss.Text,
                

            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("New User is successfully added");
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
