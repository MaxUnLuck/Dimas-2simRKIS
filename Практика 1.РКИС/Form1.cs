using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_1.РКИС
{
    public partial class Form1 : Form
    {
        private Airplane airplane;
        private Helicopter helicopter;
        private HotAirBalloon balloon;
        private double currentFuel; // Текущее количество топлива
        private const double maxFuel = 100;
        private bool gameOver = false; // Флаг, указывающий на завершение игры

        public Form1()
        {
            InitializeComponent();
            // Создаем экземпляры транспортных средств
            airplane = new Airplane("Боинг 747");
            helicopter = new Helicopter("Ми-8");
            balloon = new HotAirBalloon("Волшебный шар");
            // Заполняем ComboBox названиями транспортных средств
            vehicleComboBox.Items.AddRange(new string[] { airplane.Name, helicopter.Name, balloon.Name });

            // Инициализация топлива и отображения
            currentFuel = maxFuel;
            fuelProgressBar.Maximum = (int)maxFuel;
            fuelProgressBar.Value = (int)currentFuel;
            UpdateFuelLabel();
        }

        private void flyButton_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return; // Если игра закончена, ничего не делаем
            }

            // Проверяем, выбрано ли транспортное средство
            if (vehicleComboBox.SelectedItem == null)
            {
                resultTextBox.Text = "Пожалуйста, выберите транспортное средство.";
                return;
            }

            // Получаем название выбранного транспортного средства
            string selectedVehicleName = vehicleComboBox.SelectedItem.ToString();

            // Инициализируем переменную result ПЕРЕД switch!
            string result = "";

            // Расчет расхода топлива
            double fuelConsumption = 0;

            switch (selectedVehicleName)
            {
                case "Боинг 747":
                    result = airplane.Fly();
                    fuelConsumption = 15; // Пример расхода
                    break;
                case "Ми-8":
                    result = helicopter.Fly();
                    fuelConsumption = 20;  // Пример расхода
                    break;
                case "Волшебный шар":
                    result = balloon.Fly();
                    fuelConsumption = 5; // Пример расхода
                    break;
                default:
                    result = "Неизвестное транспортное средство.";
                    break;
            }

            // Расход топлива
            currentFuel -= fuelConsumption;

            // Проверяем, достаточно ли топлива
            if (currentFuel <= 0)
            {
                result += "\nТопливо закончилось! Аварийная посадка!";
                currentFuel = 0; // чтобы не уйти в отрицательное значение
                gameOver = true; // Устанавливаем флаг завершения игры
                flyButton.Enabled = false;  // Отключаем кнопку
                resultTextBox.Text += "\nИгра окончена. Выберите другое транспортное средство, чтобы начать заново.";
            }
            // Добавим проверку на аварию (с вероятностью, например, 5%)
            else if (new Random().Next(1, 100) <= 5) // Вероятность аварии 5%
            {
                result += "\nПроизошла авария! Игра окончена.";
                gameOver = true;
                flyButton.Enabled = false;
                resultTextBox.Text += "\nИгра окончена. Выберите другое транспортное средство, чтобы начать заново.";
            }

            // Обновляем отображение
            currentFuel = Math.Max(0, Math.Min(currentFuel, maxFuel)); // Убеждаемся, что топливо в пределах 0-maxFuel
            fuelProgressBar.Value = (int)Math.Round(currentFuel); // Исправлено здесь!
            UpdateFuelLabel();
            resultTextBox.Text = result;
        }

        // Метод для обновления текста fuelLabel
        private void UpdateFuelLabel()
        {
            fuelLabel.Text = $"Топливо: {currentFuel:F1}/{maxFuel}";
        }

        // Обработчик события SelectedIndexChanged для ComboBox
        private void vehicleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gameOver)
            {
                flyButton.Enabled = true; // Включаем кнопку, когда выбирают транспортное средство после завершения игры
                gameOver = false; // Сбрасываем флаг завершения игры
                currentFuel = maxFuel; // Сбрасываем топливо
                fuelProgressBar.Value = (int)currentFuel;
                UpdateFuelLabel();
            }
        }
    }
}
