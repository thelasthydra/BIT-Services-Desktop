﻿using System;
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
        }

        private void NewClient(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("NewClientView.xaml", UriKind.Relative));
        }
    }
}
