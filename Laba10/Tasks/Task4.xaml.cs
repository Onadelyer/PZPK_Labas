using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class Task4 : Page
    {
        public Task4()
        {
            InitializeComponent();
            LoadGraphData();
        }

        private void LoadGraphData()
        {
            // Матриця суміжності
            var adjacencyMatrix = new[,]
            {
                {0, 1, 0, 0, 1, 0, 0, 0},
                {1, 0, 1, 0, 1, 0, 0, 0},
                {0, 1, 0, 1, 1, 1, 0, 0},
                {0, 0, 1, 0, 1, 0, 1, 0},
                {1, 1, 1, 1, 0, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 0, 1},
                {0, 0, 0, 1, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 1, 1, 0}
            };
            AdjacencyMatrixDataGrid.ItemsSource = ConvertMatrixToDataTable(adjacencyMatrix).DefaultView;

            // Матриця інцидентності
            var incidenceMatrix = new[,]
            {
                {-1, -1,  0,  0,  0,  0,  0,  0,  0,  0,  0},
                { 1,  0, -1, -1,  0,  0,  0,  0,  0,  0,  0},
                { 0,  0,  0,  1, -1, -1, -1,  0,  0,  0,  0},
                { 0,  0,  0,  0,  0,  1,  0, -1, -1,  0,  0},
                { 0,  1,  1,  0,  1,  0,  0,   1,  0,  0,  0},
                { 0,  0,  0,  0,  0,  0,  1,   0,  0, -1,  0},
                { 0,  0,  0,  0,  0,  0,  0,   0,  1,  0, -1},
                { 0,  0,  0,  0,  0,  0,  0,   0,  0,  1,  1}
            };
            IncidenceMatrixDataGrid.ItemsSource = ConvertMatrixToDataTable(incidenceMatrix).DefaultView;

            // Список ребер
            var edgeList = new ObservableCollection<Tuple<char, char>>
            {
                new Tuple<char, char>('a', 'b'),
                new Tuple<char, char>('a', 'e'),
                new Tuple<char, char>('b', 'c'),
                new Tuple<char, char>('b', 'e'),
                new Tuple<char, char>('c', 'd'),
                new Tuple<char, char>('c', 'e'),
                new Tuple<char, char>('c', 'f'),
                new Tuple<char, char>('d', 'e'),
                new Tuple<char, char>('d', 'g'),
                new Tuple<char, char>('f', 'h'),
                new Tuple<char, char>('g', 'h')
            };
            EdgeListListView.ItemsSource = edgeList;
        }

        private System.Data.DataTable ConvertMatrixToDataTable(int[,] matrix)
        {
            var dataTable = new System.Data.DataTable();
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            for (int col = 0; col < colCount; col++)
                dataTable.Columns.Add(col.ToString());

            for (int row = 0; row < rowCount; row++)
            {
                var newRow = dataTable.NewRow();
                for (int col = 0; col < colCount; col++)
                    newRow[col] = matrix[row, col];
                dataTable.Rows.Add(newRow);
            }

            return dataTable;
        }
    }
}
