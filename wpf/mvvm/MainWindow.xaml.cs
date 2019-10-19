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

namespace mvvm
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeeViewModel employeeViewModel;

        public MainWindow()
        {
            InitializeComponent();
            employeeViewModel = base.DataContext as EmployeeViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            employeeViewModel.UserName = "马化腾";
            employeeViewModel.CompanyName = "腾讯";
        }
    }
}
