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
using WpfApp2.Pages;
using WpfApp2.Services;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            LoadFromServerToGrid();
        }

        private async Task LoadFromServerToGrid()
        {
            await CompanyProcessor.LoadCompanies();
            await RepresentativeProcessor.LoadRepresentatives();
            await InvoiceProcessor.LoadInvoices();
        }

        private void Logo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = null;
        }

        private void Companies_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CompaniesPage());
        }

        private void Invoices_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InvoicesPage());
        }

        private void Add_invoice_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Add_InvoicePage());
        }

        private void Add_company_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Add_CompanyPage());
        }

        private void Add_representative_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Add_RepresentativePage());
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m1 = new MainWindow();
            m1.Show();
            this.Close();
        }
    }
}
