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
    /// Interaction logic for Task1.xaml
    /// </summary>
    public partial class Task1 : Page
    {
        private CustomData data = new CustomData();


        public Task1()
        {
            InitializeComponent();

            ResultLabel.Content = data.ToString();
        }

        public void IncreaseYear(object sender, EventArgs e)
        {
            data.IncreaseYear();
            ResultLabel.Content = data.ToString();
        }

        public void DecreaseDay(object sender, EventArgs e)
        {
            data.DecreaseDayBy2();
            ResultLabel.Content = data.ToString();
        }
    }
}
