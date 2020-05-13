using BITServices.Views.Client;
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

namespace BITServices
{
    /// <summary>
    /// Interaction logic for LocationManagementView.xaml
    /// </summary>
    public partial class LocationManagementView : Page
    {
        public LocationManagementView()
        {
            InitializeComponent();
        }

        public LocationManagementView(string companyName)
        {
            InitializeComponent();
            lblTitle.Content = companyName + " Location Management";
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void NewLocation(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Content = new NewLocationView();
        }
    }
}
