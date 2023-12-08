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

namespace Laba10.Tasks
{
    /// <summary>
    /// Interaction logic for Task2.xaml
    /// </summary>
    public partial class Task2 : Page
    {
        private LinkedList<int> deque = new LinkedList<int>();

        public Task2()
        {
            InitializeComponent();
        }

        private void PushFront_Click(object sender, RoutedEventArgs e)
        {
            int value = GetRandomValue();
            deque.AddFirst(value);
            UpdateDequeListBox();
        }

        private void PushBack_Click(object sender, RoutedEventArgs e)
        {
            int value = GetRandomValue();
            deque.AddLast(value);
            UpdateDequeListBox();
        }

        private void PopFront_Click(object sender, RoutedEventArgs e)
        {
            if (deque.Count > 0)
            {
                deque.RemoveFirst();
                UpdateDequeListBox();
            }
            else
            {
                MessageBox.Show("Deque is empty");
            }
        }

        private void PopBack_Click(object sender, RoutedEventArgs e)
        {
            if (deque.Count > 0)
            {
                deque.RemoveLast();
                UpdateDequeListBox();
            }
            else
            {
                MessageBox.Show("Deque is empty");
            }
        }

        private void Front_Click(object sender, RoutedEventArgs e)
        {
            if (deque.Count > 0)
            {
                MessageBox.Show($"Front value: {deque.First.Value}");
            }
            else
            {
                MessageBox.Show("Deque is empty");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (deque.Count > 0)
            {
                MessageBox.Show($"Back value: {deque.Last.Value}");
            }
            else
            {
                MessageBox.Show("Deque is empty");
            }
        }

        private void Size_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Deque size: {deque.Count}");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            deque.Clear();
            UpdateDequeListBox();
        }

        private int GetRandomValue()
        {
            // Генеруємо випадкове значення для елемента деку
            Random random = new Random();
            return random.Next(1, 100);
        }

        private void UpdateDequeListBox()
        {
            // Оновлюємо вміст ListBox з даними деку
            dequeListBox.ItemsSource = null;
            dequeListBox.ItemsSource = deque;
        }
    }
}
