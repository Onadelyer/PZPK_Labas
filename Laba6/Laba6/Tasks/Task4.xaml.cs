using Laba6.Models;
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

namespace Laba6.Tasks
{
    /// <summary>
    /// Interaction logic for Task4.xaml
    /// </summary>
    public partial class Task4 : Page
    {
        PrintedPublication object1 = new PrintedPublication();
        Magazine object2 = new Magazine();
        Book object3 = new Book();
        Textbook object4 = new Textbook();

        List<PrintedPublication> objects = new();

        List<Label> labels = new();

        public Task4()
        {
            InitializeComponent();

            objects.Add(object1);
            objects.Add(object2);
            objects.Add(object3);
            objects.Add(object4);

            labels.Add(Label1);
            labels.Add(Label2);
            labels.Add(Label3);
            labels.Add(Label4);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < objects.Count; i++)
            {
                objects[i].Show(labels[i]);

                labels[i].Content += $"\nЦіна: {objects[i].GetPrice()}";
            }
        }
    }
}
