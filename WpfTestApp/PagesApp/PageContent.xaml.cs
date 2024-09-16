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
using WpfTestApp.DataClassApp;

namespace WpfTestApp.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageContent.xaml
    /// </summary>
    public partial class PageContent : Page
    {
        public PageContent()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e) => ClassNavigation.frmContent.GoBack();
    }
}