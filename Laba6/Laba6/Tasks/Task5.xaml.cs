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
    /// Interaction logic for Task5.xaml
    /// </summary>
    public partial class Task5 : Page
    {
        Airplane object1;
        Bomber object2;
        Fighter object3;

        public Task5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (ComboBoxType.Text)
                {
                    case("Airplane"):
                        object1 = new Airplane(TextBoxBrand.Text.ToString(), TextBoxModel.Text.ToString(), Convert.ToDouble(TextBoxMaxSpeed.Text), Convert.ToDouble(TextBoxMaxAltitude.Text));
                        Label1.Content = object1.Info();
                    break;
                    case ("Bomber"):
                        object2 = new Bomber(TextBoxBrand.Text.ToString(), TextBoxModel.Text.ToString(), Convert.ToDouble(TextBoxMaxSpeed.Text), Convert.ToDouble(TextBoxMaxAltitude.Text), "Пес патрон");
                        Label2.Content = object2.Info();
                    break;
                    case ("Fighter"):
                        object3 = new Fighter(TextBoxBrand.Text.ToString(), TextBoxModel.Text.ToString(), Convert.ToDouble(TextBoxMaxSpeed.Text), Convert.ToDouble(TextBoxMaxAltitude.Text), "Тренувальні польоти");
                        Label3.Content = object3.Info();
                    break;

                    default:
                        MessageBox.Show("Виберіть тип літака!");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
