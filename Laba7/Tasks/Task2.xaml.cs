using Laba7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Task2.xaml
    /// </summary>
    public partial class Task2 : Page
    {
        public Task2()
        {
            InitializeComponent();
            InitializeZodiacSigns();
        }

        private void InitializeZodiacSigns()
        {
            foreach (ZodiacSign sign in Enum.GetValues(typeof(ZodiacSign)))
            {
                ComboBoxZodiacSigns.Items.Add(sign);
            }
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxZodiacSigns.SelectedItem != null)
            {
                ZodiacSign selectedSign = (ZodiacSign)ComboBoxZodiacSigns.SelectedItem;
                DisplaySignAttributes(selectedSign);
            }
            else
            {
                MessageBox.Show("Please select a Zodiac sign.");
            }
        }

        private void DisplaySignAttributes(ZodiacSign sign)
        {
            switch (sign)
            {
                case ZodiacSign.Aries:
                    TextBoxResult.Content = "Aries - Fire element (activity, initiation)";
                    break;
                case ZodiacSign.Taurus:
                    TextBoxResult.Content = "Taurus - Earth element (perseverance, accumulation)";
                    break;
                case ZodiacSign.Gemini:
                    TextBoxResult.Content = "Gemini - Air element (movement, communication)";
                    break;
                case ZodiacSign.Cancer:
                    TextBoxResult.Content = "Cancer - Water element (emotion, intuition)";
                    break;
                case ZodiacSign.Leo:
                    TextBoxResult.Content = "Leo - Fire element (individualization, creative self-expression)";
                    break;
                case ZodiacSign.Virgo:
                    TextBoxResult.Content = "Virgo - Earth element (service, detail orientation)";
                    break;
                case ZodiacSign.Libra:
                    TextBoxResult.Content = "Libra - Air element (balance, duality)";
                    break;
                case ZodiacSign.Scorpio:
                    TextBoxResult.Content = "Scorpio - Water element (transformation, instinctiveness)";
                    break;
                case ZodiacSign.Sagittarius:
                    TextBoxResult.Content = "Sagittarius - Fire element (worldview, spirituality)";
                    break;
                case ZodiacSign.Capricorn:
                    TextBoxResult.Content = "Capricorn - Earth element (responsibility, goal-oriented)";
                    break;
                case ZodiacSign.Aquarius:
                    TextBoxResult.Content = "Aquarius - Air element (independence, innovation)";
                    break;
                case ZodiacSign.Pisces:
                    TextBoxResult.Content = "Pisces - Water element (sacrifice, depth)";
                    break;
                case ZodiacSign.Ophiuchus:
                    TextBoxResult.Content = "Ophiuchus - Unknown element (mysterious, transformative)";
                    break;
                default:
                    TextBoxResult.Content = "Invalid Zodiac sign.";
                    break;
            }
        }
    }
}
