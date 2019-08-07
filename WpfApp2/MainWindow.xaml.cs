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
using WpfApp2.Models;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await LoginProcessor.LoadLogin(Login.Text, Password.Password);
            if(LoginProcessor.isTrue)
            {
                await AuthorizationProcessor.LoadAuth();
                Window1 win1 = new Window1();
                win1.Show();
                win1.loggedUser.Text = Login.Text;
                this.Close();
            }
            else
            {
                Wrong_data.Visibility = Visibility.Visible;
            }
        {
}
    }
    }
}
