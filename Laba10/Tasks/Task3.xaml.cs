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
    /// Interaction logic for Task3.xaml
    /// </summary>
    public partial class Task3 : Page
    {
        private class TreeNode
        {
            public string Day { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(string day)
            {
                Day = day;
            }
        }

        private TreeNode root;

        public Task3()
        {
            InitializeComponent();
            InitializeTree();
        }

        private void InitializeTree()
        {
            string[] defaultSchedule = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            foreach (var day in defaultSchedule)
            {
                AddDayToTree(day);
            }
        }

        private void AddDayToTree(string day)
        {
            root = AddDayRecursive(root, day);
        }

        private TreeNode AddDayRecursive(TreeNode node, string day)
        {
            if (node == null)
            {
                return new TreeNode(day);
            }

            if (String.Compare(day, node.Day, StringComparison.OrdinalIgnoreCase) < 0)
            {
                node.Left = AddDayRecursive(node.Left, day);
            }
            else if (String.Compare(day, node.Day, StringComparison.OrdinalIgnoreCase) > 0)
            {
                node.Right = AddDayRecursive(node.Right, day);
            }

            return node;
        }

        private TreeNode RemoveDay(TreeNode node, string day)
        {
            if (node == null)
            {
                return node;
            }

            if (String.Compare(day, node.Day, StringComparison.OrdinalIgnoreCase) < 0)
            {
                node.Left = RemoveDay(node.Left, day);
            }
            else if (String.Compare(day, node.Day, StringComparison.OrdinalIgnoreCase) > 0)
            {
                node.Right = RemoveDay(node.Right, day);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Day = FindMinValue(node.Right).Day;
                node.Right = RemoveDay(node.Right, node.Day);
            }

            return node;
        }

        private TreeNode FindMinValue(TreeNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        private void TraverseTree(TreeNode node, List<string> result)
        {
            if (node != null)
            {
                TraverseTree(node.Left, result);
                result.Add(node.Day);
                TraverseTree(node.Right, result);
            }
        }

        private bool SearchDay(TreeNode node, string day)
        {
            if (node == null)
            {
                return false;
            }

            int compareResult = String.Compare(day, node.Day, StringComparison.OrdinalIgnoreCase);

            if (compareResult < 0)
            {
                return SearchDay(node.Left, day);
            }
            else if (compareResult > 0)
            {
                return SearchDay(node.Right, day);
            }
            else
            {
                return true;
            }
        }

        private void AddDay_Click(object sender, RoutedEventArgs e)
        {
            string day = inputTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(day))
            {
                AddDayToTree(day);
            }
            inputTextBox.Clear();
        }

        private void RemoveDay_Click(object sender, RoutedEventArgs e)
        {
            string day = inputTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(day))
            {
                root = RemoveDay(root, day);
            }
            inputTextBox.Clear();
        }

        private void TraverseTree_Click(object sender, RoutedEventArgs e)
        {
            List<string> result = new List<string>();
            TraverseTree(root, result);
            MessageBox.Show($"Schedule: {string.Join(", ", result)}");
        }

        private void SearchDay_Click(object sender, RoutedEventArgs e)
        {
            string day = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(day))
            {
                bool found = SearchDay(root, day);
                MessageBox.Show(found ? $"{day} found in the schedule." : $"{day} not found in the schedule.");
            }
            searchTextBox.Clear();
        }
    }
}
