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

namespace LectureEx_IComparble_Hafsa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> student = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();

            //1) The IComparable and IComparer interfaces in C# are used for sorting and comparing objects in collections like lists, arrays, and other data structures

            //2) a zero, negative number and a positive number

            //3) you use the Sort method 

            //4) the <T> signifies that these interfaces are generic meaning they can work with any type

            student.Add(new Student("John", "Doe"));
            student.Add(new Student("Jane", "Smith"));
            student.Add(new Student("Alice", "Johnson"));
            student.Add(new Student("Bob", "Brown"));
            student.Add(new Student("Eve", "Taylor"));

            DisplayStudents();

        }

        private void DisplayStudents()
        {
            listbox.Items.Clear();
            foreach (var student in student)
            {
                listbox.Items.Add(student.ToString());
            }
        }

    }
}
