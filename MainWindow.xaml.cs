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

namespace EmployeeWageManager
{
    
    public partial class MainWindow : Window
    {
        List<Employee> employees = new List<Employee>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {            
            employeeCbx.Items.Add("Floor clerk");
            employeeCbx.Items.Add("Cashier");
            employeeCbx.Items.Add("Manager");

            employees.Add(new FloorClerk("amr", 10));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string resultWage="0";

            if ((string)employeeCbx.SelectedItem == "Floor clerk")
            {
                FloorClerk floorClerk = new FloorClerk("Amr", 10);
                resultWage= floorClerk.GetSalary().ToString();
            }
            else if ((string)employeeCbx.SelectedItem == "Manager")
            {
                Manager manager = new Manager();
                resultWage= manager.GetSalary().ToString();
            }
            else if ((string)employeeCbx.SelectedItem == "Cashier")
            {
                Cashier cashier = new Cashier();
                resultWage= cashier.GetSalary().ToString();
            }

            resultlbl.Content = resultWage + "$";
        }

        private void employeeCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if ((string)employeeCbx.SelectedItem == "Floor clerk")
            {
                employeeNameCbx.Items.Clear();
                employeeNameCbx.Items.Add("Amr");
            }
            else if ((string)employeeCbx.SelectedItem == "Manager")
            {
                employeeNameCbx.Items.Clear();
                employeeNameCbx.Items.Add("test");
            }
            else
            {
                employeeNameCbx.Items.Clear();
            }
        }
    }
}
