using Laba5;
using Laba7.Models;
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

namespace Laba7.Tasks
{
    /// <summary>
    /// Interaction logic for Task1.xaml
    /// </summary>
    public partial class Task1 : Page
    {
        private List<Student> students = new List<Student>();

        public Task1()
        {
            InitializeComponent();

            students = FileHandler.ReadFromBinaryFile<List<Student>>("students.bin");

            UpdateResultLabel(students);
        }

        public void AddStudent(object sender, RoutedEventArgs e)
        {
            Student? newStudent = GetStudentFromInput();

            if (newStudent == null)
                return;

            students.Add(newStudent.Value);

            UpdateResultLabel(students);
        }

        public void SortStudents(object sender, RoutedEventArgs e)
        {
            var studentsSorted = students.OrderBy(students => students.Group).ToList();

            UpdateResultLabel(studentsSorted, false);
        }

        public void SelectStudents(object sender, RoutedEventArgs e)
        {
            var studentsSelected = students.Where(students => students.Ses.Average() > 4).ToList();

            if(students.Count == 0)
                ResultLabel.Content = "Немає студентів з середнім балом більше 4";
            else
                UpdateResultLabel(studentsSelected, false);

        }

        public Student? GetStudentFromInput()
        {
            try
            {
                string name = NameBox.Text;

                int group = int.Parse(GroupBox.Text);

                int[] ses = MarksBox.Text.Split(",").Select(n => int.Parse(n)).ToArray();

                return new Student(name, group, ses);
            }
            catch (Exception)
            {
                MessageBox.Show("Дані введено некоректно");
                return null;
            }
        }

        public void UpdateResultLabel(List<Student> students, bool writeFile = true)
        {
            if(students == default(List<Student>))
                return;

            ResultLabel.Content = "";
            foreach (Student s in students)
                ResultLabel.Content += s.ToString() + "\n";

            if(writeFile)
                FileHandler.WriteToBinaryFile<List<Student>>("students.bin", students);
        }
    }
}
