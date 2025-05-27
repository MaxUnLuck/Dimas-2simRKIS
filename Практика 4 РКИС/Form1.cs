using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_4_РКИС
{
    public partial class Form1 : Form
    {
            private readonly Сounting matrixCounter;
            public Form1()
            {
                InitializeComponent();
                matrixCounter = new Сounting();
            }

            private void btnGenerate_Click(object sender, EventArgs e)
            {
                try
                {
                    int row = int.Parse(txtRows.Text);
                    int col = int.Parse(txtCols.Text);
                    int min = int.Parse(txtMin.Text);
                    int max = int.Parse(txtMax.Text);
                    int[,] arr = matrixCounter.GenArr(row, col, min, max);
                    DisplayMatrix(arr);
                    int count = matrixCounter.NegElCount(arr);
                    lblResult.Text = $"Количество четных отрицательных элементов: {count}";
                    lblResult.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    lblResult.Text = $"Ошибка: {ex.Message}";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
            private void DisplayMatrix(int[,] arr)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                int rows = arr.GetLength(0);
                int cols = arr.GetLength(1);
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Columns.Add($"Столбцы{j}", $"Столбец {j + 1}");
                }                
                for (int i = 0; i < rows; i++)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);

                    for (int j = 0; j < cols; j++)
                    {
                        row.Cells[j].Value = arr[i, j];
                    }
                    dataGridView1.Rows.Add(row);
                }
            }
            private void btnClear_Click(object sender, EventArgs e)
            {
                txtRows.Clear();
                txtCols.Clear();
                txtMin.Clear();
                txtMax.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                lblResult.Text = "Введите параметры матрицы";
                lblResult.ForeColor = System.Drawing.Color.Black;
            }

        
    }
}


