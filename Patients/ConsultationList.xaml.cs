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
    /// Interaction logic for ConsultationList.xaml
    /// </summary>
    public partial class ConsultationList : Window
    {
        public ConsultationList(Models.Patient consultation)
        {
            InitializeComponent();

            var conList = BLL.ConsultationBLL.List(consultation.PatientID);
            dgCons.ItemsSource = conList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
