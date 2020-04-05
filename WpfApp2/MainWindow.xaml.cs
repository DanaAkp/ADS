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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
        }

        private void Btn_department_sales_Click(object sender, RoutedEventArgs e)
        {
            WindowsPrincipal principial = (WindowsPrincipal)Thread.CurrentPrincipal;
            if (!principial.IsInRole("SalesDepartment"))
            {
                MessageBox.Show("Нет прав доступа!");
                return;
            }
            new SalesDepartmentWindow().ShowDialog();

        }

        private void Btn_department_personnel_Click(object sender, RoutedEventArgs e)
        {
            WindowsPrincipal principial = (WindowsPrincipal)Thread.CurrentPrincipal;
            if (!principial.IsInRole("AccountingDepartment"))
            {
                MessageBox.Show("Нет прав доступа!");
                return;
            }
            new AccountingWindow().ShowDialog();

        }

        private void Btn_department_accounting_Click(object sender, RoutedEventArgs e)
        {
            WindowsPrincipal principial = (WindowsPrincipal)Thread.CurrentPrincipal;
            if (!principial.IsInRole("HumanResourcesDepartment"))
            {
                MessageBox.Show("Нет прав доступа!");
                return;
            }
            new HumanResourcesDepartmentWindow().ShowDialog();

        }
    }
}
