using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ПР3РКИС;

namespace ПР3РКИС
{
    public partial class Form1 : Form
    {
        private DictionaryProcessor processor = new DictionaryProcessor();

        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Работа со словарями";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(650, 500);

            keysTextBox.Text = "яблоко, банан, апельсин, яблоко, груша";
            valuesTextBox.Text = "красный, желтый, оранжевый, зеленый, зеленый";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();

                if (string.IsNullOrWhiteSpace(keyTextBox.Text) || string.IsNullOrWhiteSpace(valueTextBox.Text))
                {
                    errorProvider.SetError(keyTextBox, "Введите ключ");
                    errorProvider.SetError(valueTextBox, "Введите значение");
                    statusLabel.Text = "Введите и ключ, и значение";
                    return;
                }

                processor.AddPair(keyTextBox.Text.Trim(), valueTextBox.Text.Trim());
                UpdateDictionaryDisplay();

                keyTextBox.Clear();
                valueTextBox.Clear();
                statusLabel.Text = $"Пара добавлена: {keyTextBox.Text} - {valueTextBox.Text}";
            }
            catch (ArgumentException ex)
            {
                errorProvider.SetError(keyTextBox, ex.Message);
                statusLabel.Text = ex.Message;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            processor.GenerateRandomPairs(5);
            UpdateDictionaryDisplay();
            statusLabel.Text = "Сгенерировано 5 случайных пар";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            processor.Clear();
            dictionaryListBox.Items.Clear();
            duplicatesListBox.Items.Clear();
            statusLabel.Text = "Словарь очищен";
        }

        private void findDuplicatesButton_Click(object sender, EventArgs e)
        {
            try
            {
                var duplicates = processor.FindDuplicateValues();
                duplicatesListBox.Items.Clear();

                if (duplicates.Count > 0)
                {
                    duplicatesListBox.Items.Add("Дубликаты значений:");
                    foreach (var dup in duplicates)
                    {
                        duplicatesListBox.Items.Add($"{dup.Key} (встречается {dup.Value} раз)");
                    }
                    statusLabel.Text = $"Найдено {duplicates.Count} дубликатов значений";
                }
                else
                {
                    duplicatesListBox.Items.Add("Дубликаты не найдены");
                    statusLabel.Text = "Дубликаты значений не найдены";
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void UpdateDictionaryDisplay()
        {
            dictionaryListBox.Items.Clear();
            foreach (var pair in processor.GetDictionary())
            {
                dictionaryListBox.Items.Add($"{pair.Key} : {pair.Value}");
            }
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}