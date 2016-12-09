using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XMLReaderProject
{
    public class Employee: ObservableObject
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
                SetField(ref name, value, "Name");
            }
        }

        string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            private set
            {
                name = value;
                SetField(ref surname, value, "Surname");
            }
        }

        string cellphoneNr;
        public string CellphoneNr
        {
            get
            {
                return cellphoneNr;
            }
            private set
            {
                name = value;
                SetField(ref cellphoneNr, value, "CellphoneNr");
            }
        }

        public Employee(string _name, string _surname, string _cellpnonenr)
        {
            name = _name;
            surname = _surname;
            cellphoneNr = _cellpnonenr;
        }
    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Employee emp = new Employee("Jane", "Patterson", "8883339994");

            DataContext = emp;

            InitializeComponent();
        }
    }
}
