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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Department_Accounting.xaml
    /// </summary>
    public partial class Department_Accounting : Window
    {
        public Department_Accounting()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            object win = this.Parent;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
