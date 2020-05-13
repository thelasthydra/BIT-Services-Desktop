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
    /// Interaction logic for ClientManagementView.xaml
    /// </summary>
    public partial class ClientManagementView : Page
    {
        public ClientManagementView()
        {
            InitializeComponent();
            this.DataContext = new ClientManagementViewModel();   
        }

        private void NewClient(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Content = new NewClientView();
        }

        private void ManageLocations(object sender, RoutedEventArgs e)
        {
            int rows = dgClient.SelectedItems.Count;
            rows = 1;
            if (rows != 0)
            {
                this.NavigationService.Content = new LocationManagementView();
            }
            else { MessageBox.Show("You Must Select A Client Before Proceeding", "ERROR: No Client Selected", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

        private void ManageStaff(object sender, RoutedEventArgs e)
        {
            
            int rows = dgClient.SelectedItems.Count;
            rows = 1;
            if (rows != 0)
            {
                this.NavigationService.Content = new StaffManagementView();
            } else { MessageBox.Show("You Must Select A Client Before Proceeding", "ERROR: No Client Selected", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
    }
}
