using System;
using System.Windows.Forms;
using System.Drawing;
using Практика_3_РКИС;

namespace Практика_3_РКИС
{
    
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void buttonCalculate_Click(object sender, EventArgs e)
            {
                try
                {
                    if (!double.TryParse(textBoxX1.Text, out double x1))
                    {
                        MessageBox.Show("Неверный формат X1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(textBoxY1.Text, out double y1))
                    {
                        MessageBox.Show("Неверный формат Y1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(textBoxX2.Text, out double x2))
                    {
                        MessageBox.Show("Неверный формат X2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(textBoxY2.Text, out double y2))
                    {
                        MessageBox.Show("Неверный формат Y2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    double distance = Calculate.CalculateDistance(x1, y1, x2, y2);
                    labelResult.Text = "Расстояние: " + distance.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }