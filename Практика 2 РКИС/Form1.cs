using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_2_РКИС
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> numbers = new List<int>();

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.SetError(inputTextBox, "");
                if (string.IsNullOrWhiteSpace(inputTextBox.Text))
                {
                    errorProvider.SetError(inputTextBox, "Введите число");
                    statusLabel.Text = "Пожалуйста, введите число";
                    return;
                }

                int number = int.Parse(inputTextBox.Text);
                numbers.Add(number);
                originalListBox.Items.Add(number);
                inputTextBox.Clear();
                statusLabel.Text = $"Число {number} добавлено";
            }
            catch (FormatException)
            {
                errorProvider.SetError(inputTextBox, "Неверный формат");
                statusLabel.Text = "Введите целое число";
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            originalListBox.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(1, 100);
                numbers.Add(num);
                originalListBox.Items.Add(num);
            }
            statusLabel.Text = "Сгенерировано 10 случайных чисел";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            originalListBox.Items.Clear();
            resultListBox.Items.Clear();
            statusLabel.Text = "Списки очищены";
        }

        private void dividerTextBox_Enter(object sender, EventArgs e)
        {
            if (dividerTextBox.Text == "Введите делитель")
                dividerTextBox.Text = "";
        }

        private void dividerTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dividerTextBox.Text))
                dividerTextBox.Text = "Введите делитель";
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.SetError(dividerTextBox, "");
                if (numbers.Count == 0)
                {
                    statusLabel.Text = "Список пуст! Добавьте числа";
                    return;
                }
                int firstElement = numbers[0];
                dividerTextBox.Text = firstElement.ToString();

                resultListBox.Items.Clear();
                int count = 0;

                foreach (int number in numbers)
                {
                    if (number % firstElement != 0)
                    {
                        resultListBox.Items.Add(number);
                        count++;
                    }
                }

                statusLabel.Text = $"Удалено {numbers.Count - count} элементов. " +
                                 $"Осталось: {count}. Делитель: {firstElement}";
            }
            catch (Exception ex)
            {
                errorProvider.SetError(dividerTextBox, "Ошибка обработки");
                statusLabel.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
