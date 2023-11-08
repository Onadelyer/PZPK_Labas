using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba5.Tasks
{
    /// <summary>
    /// Interaction logic for Task4.xaml
    /// </summary>
    public partial class Task4 : Page
    {
        public Task4()
        {
            InitializeComponent();

            InputGrid.ItemsSource = ConvertToDataTable(FileHandler.ReadFromBinaryFile<int[,]>("Task4Input.bin")).DefaultView;
            OutputGrid.ItemsSource = ConvertToDataTable(FileHandler.ReadFromBinaryFile<int[,]>("Task4Output.bin")).DefaultView;
        }

        private DataTable ConvertToDataTable(int[,] matrix)
        {
            if (matrix == null)
                matrix = new int[5,5];

            DataTable dataTable = new DataTable();

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataTable.Columns.Add($"Column {i + 1}");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataRow[j] = matrix[i, j];
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        private int[,] GetMatrixFromDataGrid(DataGrid dataGrid)
        {
            int rowCount = dataGrid.Items.Count-1;
            int columnCount = dataGrid.Columns.Count;
            int[,] matrix = new int[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(i);
                if (row != null)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        string cellValue = (dataGrid.Columns[j].GetCellContent(row) as TextBlock).Text;
                        if (int.TryParse(cellValue, out int cellIntValue))
                        {
                            matrix[i, j] = cellIntValue;
                        }
                        else
                        {
                            matrix[i, j] = -1;
                        }
                    }
                }
            }

            return matrix;
        }

        private int[,] GetRotatedMatrixOn90Degrees(int[,] matrix)
        {
            int originalRows = matrix.GetLength(0);
            int originalColumns = matrix.GetLength(1);

            // Swapping dimensions for the rotated matrix
            int rotatedRows = originalColumns;
            int rotatedColumns = originalRows;

            int[,] rotatedMatrix = new int[rotatedRows, rotatedColumns];

            for (int i = 0; i < originalRows; i++)
            {
                for (int j = 0; j < originalColumns; j++)
                {
                    rotatedMatrix[j, originalRows - 1 - i] = matrix[i, j];
                }
            }

            return rotatedMatrix;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[,] matrix = GetMatrixFromDataGrid(InputGrid);
            int[,] rotatedMatrix = GetRotatedMatrixOn90Degrees(matrix);

            FileHandler.WriteToBinaryFile("Task4Input.bin", matrix);
            FileHandler.WriteToBinaryFile("Task4Output.bin", rotatedMatrix);

            OutputGrid.ItemsSource = ConvertToDataTable(rotatedMatrix).DefaultView;
            OutputGrid.Items.Refresh();

            InputGrid.ItemsSource = ConvertToDataTable(matrix).DefaultView;
            InputGrid.Items.Refresh();
        }
    }
}
