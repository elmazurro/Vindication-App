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
    /// Logika interakcji dla klasy Add_CompanyPage.xaml
    /// </summary>
    public partial class Add_CompanyPage : Page
    {
        public Add_CompanyPage()
        {
            InitializeComponent();
        }

        private async void Submit_add_company_Click(object sender, RoutedEventArgs e)
        {
            CompanyModel tempCompany = new CompanyModel(companyName.Text, nip.Text,  country.Text, address.Text, city.Text);
            await CompanyProcessor.UploadCompany(tempCompany);
            this.NavigationService.Navigate(new CompaniesPage());
        }
    }
}
 