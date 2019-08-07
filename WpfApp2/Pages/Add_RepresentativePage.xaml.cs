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
    /// Logika interakcji dla klasy Add_RepresentativePage.xaml
    /// </summary>
    public partial class Add_RepresentativePage : Page
    {
        public Add_RepresentativePage()
        {
            InitializeComponent();
            Fill_comboboxes();
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

        private async void Submit_add_representative_Click(object sender, RoutedEventArgs e)
        {
            RepresentativeModel tempRepresentative = new RepresentativeModel(name.Text, surname.Text, Convert.ToInt32(contactNumber.Text), email.Text, Convert.ToInt32((companyId.SelectedItem as Models.ComboBoxItem).Value));
            await RepresentativeProcessor.UploadRepresentative(tempRepresentative);
            this.NavigationService.Navigate(new CompaniesPage());
        }
    }
}
