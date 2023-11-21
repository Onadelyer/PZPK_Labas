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
    /// Interaction logic for Task2.xaml
    /// </summary>
    public partial class Task2 : Page
    {
        private Bicycle Bicycle = new Bicycle();

        public Task2()
        {
            InitializeComponent();

            ResultLabel.Content = Bicycle.DisplayInfo();
        }

        public void Increase(object sender, EventArgs e)
        {
            Bicycle.Accelerate(2);
            ResultLabel.Content = Bicycle.DisplayInfo();
        }

        public void Stop(object sender, EventArgs e)
        {
            Bicycle.Brake();
            ResultLabel.Content = Bicycle.DisplayInfo();
        }
    }
}
