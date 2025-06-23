using System;
using System.Collections.Generic;

namespace DealerCenter
{
    public struct Car
    {
        private string _model;
        private string _brand;
        private int _year;
        private string _configuration;
        private decimal _price;

        public string Model
        {
            get => _model;
            set => _model = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Модель не может быть пустой");
        }

        public string Brand
        {
            get => _brand;
            set => _brand = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Фирма не может быть пустой");
        }

        public int Year
        {
            get => _year;
            set => _year = (value >= 1886 && value <= DateTime.Now.Year) ? value : throw new ArgumentException($"Год должен быть между 1886 и {DateTime.Now.Year}");
        }

        public string Configuration
        {
            get => _configuration;
            set => _configuration = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Комплектация не может быть пустой");
        }

        public decimal Price
        {
            get => _price;
            set => _price = value >= 0 ? value : throw new ArgumentException("Цена не может быть отрицательной");
        }

        public void OutputInfo()
        {
            Console.WriteLine($"Модель: {_model}");
            Console.WriteLine($"Фирма: {_brand}");
            Console.WriteLine($"Год выпуска: {_year}");
            Console.WriteLine($"Комплектация: {_configuration}");
            Console.WriteLine($"Цена: {_price:C}");
            Console.WriteLine(new string('-', 30));
        }
    }

    public class DealerCenterProgram
    {
        private List<Car> _cars = new List<Car>();

        public void Run()
        {
            Console.WriteLine("=== ДИЛЕРСКИЙ ЦЕНТР ===");
            Console.WriteLine("Добро пожаловать в систему учета автомобилей!\n");

            bool exitRequested = false;
            while (!exitRequested)
            {
                try
                {
                    Console.WriteLine("\nМЕНЮ:");
                    Console.WriteLine("1. Добавить автомобили");
                    Console.WriteLine("2. Показать все автомобили (по году выпуска)");
                    Console.WriteLine("3. Найти автомобиль по модели");
                    Console.WriteLine("4. Показать самый дорогой автомобиль");
                    Console.WriteLine("5. Выход");
                    Console.Write("Выберите действие (1-5): ");

                    string choice = Console.ReadLine();
                    Console.WriteLine();

                    switch (choice)
                    {
                        case "1":
                            AddCars();
                            break;
                        case "2":
                            ShowSortedCars();
                            break;
                        case "3":
                            FindCarByModel();
                            break;
                        case "4":
                            ShowMostExpensiveCar();
                            break;
                        case "5":
                            exitRequested = true;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Пожалуйста, введите число от 1 до 5.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nОШИБКА: {ex.Message}");
                    Console.WriteLine("Пожалуйста, попробуйте снова.");
                }
            }

            Console.WriteLine("\nРабота программы завершена. Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        private void AddCars()
        {
            Console.WriteLine("=== ДОБАВЛЕНИЕ АВТОМОБИЛЕЙ ===");
            Console.Write("Введите количество автомобилей для добавления: ");

            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
                throw new ArgumentException("Некорректное количество. Введите положительное число.");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nАвтомобиль #{i + 1}:");
                Car car = new Car();

                Console.Write("Модель: ");
                car.Model = Console.ReadLine();

                Console.Write("Фирма: ");
                car.Brand = Console.ReadLine();

                Console.Write("Год выпуска: ");
                if (!int.TryParse(Console.ReadLine(), out int year))
                    throw new ArgumentException("Некорректный год. Введите число.");
                car.Year = year;

                Console.Write("Комплектация: ");
                car.Configuration = Console.ReadLine();

                Console.Write("Цена: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal price))
                    throw new ArgumentException("Некорректная цена. Введите число.");
                car.Price = price;

                _cars.Add(car);
                Console.WriteLine("Автомобиль успешно добавлен!");
            }
        }

        private void ShowSortedCars()
        {
            Console.WriteLine("=== СПИСОК АВТОМОБИЛЕЙ ===");

            if (_cars.Count == 0)
            {
                Console.WriteLine("Список автомобилей пуст.");
                return;
            }

            _cars.Sort((x, y) => x.Year.CompareTo(y.Year));

            Console.WriteLine($"Всего автомобилей: {_cars.Count}\n");
            foreach (var car in _cars)
            {
                car.OutputInfo();
            }
        }

        private void FindCarByModel()
        {
            Console.WriteLine("=== ПОИСК АВТОМОБИЛЯ ===");

            if (_cars.Count == 0)
            {
                Console.WriteLine("Список автомобилей пуст. Невозможно выполнить поиск.");
                return;
            }

            Console.Write("Введите модель автомобиля для поиска: ");
            string model = Console.ReadLine();

            bool found = false;
            foreach (var car in _cars)
            {
                if (car.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nНайден автомобиль:");
                    car.OutputInfo();
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine($"Автомобиль с моделью '{model}' не найден.");
        }

        private void ShowMostExpensiveCar()
        {
            Console.WriteLine("=== САМЫЙ ДОРОГОЙ АВТОМОБИЛЬ ===");

            if (_cars.Count == 0)
            {
                Console.WriteLine("Список автомобилей пуст.");
                return;
            }

            Car mostExpensive = _cars[0];
            foreach (var car in _cars)
            {
                if (car.Price > mostExpensive.Price)
                    mostExpensive = car;
            }

            Console.WriteLine("\nСамый дорогой автомобиль в наличии:");
            mostExpensive.OutputInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DealerCenterProgram program = new DealerCenterProgram();
            program.Run();
        }
    }
}