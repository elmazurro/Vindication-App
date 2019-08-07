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
using WpfApp2.Services;

namespace WpfApp2.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy RepresentativesPage.xaml
    /// </summary>
    public partial class RepresentativesPage : Page
    {
        public RepresentativesPage(int id)
        {
            InitializeComponent();
            Representatives_Grid.DataContext = RepresentativeProcessor.RepresentativesFromCompany(id);
        }
    }
}
