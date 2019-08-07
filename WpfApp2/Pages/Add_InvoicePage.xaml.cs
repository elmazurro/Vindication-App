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
using WpfApp2.Models;
using WpfApp2.Services;

namespace WpfApp2.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy Add_InvoicePage.xaml
    /// </summary>
    public partial class Add_InvoicePage : Page
    {
        public Add_InvoicePage()
        {
            InitializeComponent();
            Fill_comboboxes();
        }

        private async void Submit_add_invoice_Click(object sender, RoutedEventArgs e)
        {
            InvoiceModel tempInvoice = new InvoiceModel(invoice.Text, Convert.ToDouble(netAmount.Text), Convert.ToDouble(grossAmount.Text), Convert.ToDouble(percent.Text), (companyId.SelectedItem as Models.ComboBoxItem).Value.ToString(), (employeeId.SelectedItem as Models.ComboBoxItem).Value.ToString(), dateOfReturn.SelectedDate);
            await InvoiceProcessor.UploadInvoice(tempInvoice);
            this.Content = null;
        }

        private void Fill_comboboxes()
        {
            foreach (CompanyModel company in CompanyProcessor.data)
            {
                Models.ComboBoxItem item = new Models.ComboBoxItem();
                item.Content = company.companyName;
                item.Value = company.id;
                companyId.Items.Add(item);
            }

            
        }

        private void EmployeeId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            employeeId.Items.Clear();
            employeeId.Visibility = Visibility.Visible;
            employeeText.Visibility = Visibility.Visible;
            int companyIdd = Convert.ToInt32((companyId.SelectedItem as Models.ComboBoxItem).Value.ToString());
            List<RepresentativeModel> tempRepList = RepresentativeProcessor.data.Where(item => item.companyId == companyIdd).Select(item => item).ToList();
            foreach (RepresentativeModel representative in tempRepList)
            {
                Models.ComboBoxItem item = new Models.ComboBoxItem();
                item.Content = representative.name + " " + representative.surname;
                item.Value = representative.id;
                employeeId.Items.Add(item);
            }
        }
    }
}
