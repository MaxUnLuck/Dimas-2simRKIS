using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1.РКИС
{
    public interface IFlyingVehicle
    {
        string Name { get; }
        string Fly();
    }
    // Абстрактный базовый класс
    public abstract class FlyingVehicle : IFlyingVehicle
    {
        public string Name { get; protected set; }
        public abstract string Fly();
    }
    // Класс самолета
    public class Airplane : FlyingVehicle
    {
        public Airplane(string name)
        {
            Name = name;
        }
        public override string Fly()
        {
            Random random = new Random();
            int eventNumber = random.Next(1, 8); // Случайное число от 1 до 7

            switch (eventNumber)
            {
                case 1:
                    return "Полет прошел успешно, вы достигли пункта назначения!";
                case 2:
                    return "Турбулентность! Пассажиров немного потрясло, но все в порядке.";
                case 3:
                    return "Небольшая задержка из-за погодных условий, но сейчас все хорошо.";
                case 4:
                    return "К сожалению, не хватило топлива, все разбились.";
                case 5:
                    return "Встретили стаю птиц, повреждения незначительные.";
                case 6:
                    return "Пока мы летели, нас подбили инопланетяне, теперь мы в плену!";
                case 7:
                    return "Один из двигателей вышел из строя, но пилоты справились.";
                default:
                    return "Неизвестное событие.";
            }
        }
    }
    // Класс вертолета
    public class Helicopter : FlyingVehicle
    {
        public Helicopter(string name)
        {
            Name = name;
        }
        public override string Fly()
        {
            Random random = new Random();
            int eventNumber = random.Next(1, 7);

            switch (eventNumber)
            {
                case 1:
                    return "Успешно добрались до места назначения!";
                case 2:
                    return "Сильный боковой ветер, полет немного экстремальный.";
                case 3:
                    return "К сожалению, отказал двигатель, пришлось совершить аварийную посадку.";
                case 4:
                    return "Столкнулись с дроном, незначительные повреждения.";
                case 5:
                    return "Полет проходил над горами, очень красиво!";
                case 6:
                    return "Пока мы летели, нас атаковали инопланетные дроны, уцелели чудом!";
                default:
                    return "Неизвестное событие.";
            }
        }
    }
    // Класс воздушного шара
    public class HotAirBalloon : FlyingVehicle
    {
        public HotAirBalloon(string name)
        {
            Name = name;
        }
        public override string Fly()
        {
            Random random = new Random();
            int eventNumber = random.Next(1, 6);

            switch (eventNumber)
            {
                case 1:
                    return "Полет прошел замечательно, виды потрясающие!";
                case 2:
                    return "Сильный ветер отнес нас немного в сторону.";
                case 3:
                    return "Закончился газ в баллоне, пришлось приземлиться в поле.";
                case 4:
                    return "Встретили стаю гусей, было весело!";
                case 5:
                    return "Пока мы летели, нас заметили инопланетяне и пригласили на чай!";
                default:
                    return "Неизвестное событие.";
            }
        }
    }
}
