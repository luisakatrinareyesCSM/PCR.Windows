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
using PatientConsultationRecord.BLL;

namespace PatientConsultationRecord.Patients
{
    /// <summary>
    /// Interaction logic for PatientList.xaml
    /// </summary>
    public partial class PatientList : Window
    {
        private string sortBy = "last name";
        private string sortOrder = "asc";
        private int pageSize = 1;
        private int pageIndex = 1;
        private long pageCount = 1;
        private string keyword = "";
        public PatientList()
        {
            InitializeComponent();

            cboSortBy.ItemsSource = new List<string>() { "First Name", "Last Name" };
            cboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };

            showData();
        }

        private void showData()
        {
            var patients = PatientBLL.Search(pageIndex, pageSize, sortBy, sortOrder,keyword);

            dgEmployees.ItemsSource = patients.Items;
            pageCount = patients.PageCount;
        }

        private void cboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sortBy = cboSortBy.SelectedValue.ToString();
            showData();
        }

        private void cboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSortOrder.SelectedValue.ToString().ToLower() == "ascending")
            {
                sortOrder = "asc";
            }
            else
            {
                sortOrder = "desc";
            }
            showData();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            showData();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;
            if (pageIndex < 1)
            {
                pageIndex = 1;
            };
            showData();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;
            if (pageIndex > pageCount)
            {
                pageIndex = (int)pageCount;
            };
            showData();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = (int)pageCount;
            showData();
        }

        private void txtPageSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPageSize.Text.Length > 0)
            {
                int.TryParse(txtPageSize.Text, out pageSize);
            }

            showData();
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                keyword = txtKeyword.Text;
                showData();
            }
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            Models.Patient patient = ((FrameworkElement)sender).DataContext as Models.Patient;
            ConsultationList conForm = new ConsultationList(patient);
            conForm.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Models.Patient patient = ((FrameworkElement)sender).DataContext as Models.Patient;
            addCosultation AddconForm = new addCosultation(patient);
            AddconForm.Show();
        }

        private void dgEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
