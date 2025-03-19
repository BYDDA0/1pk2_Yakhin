using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03
{
    internal class Car
    {
        // Свойства
        public string LicensePlate { get; set; } // Номер авто
        public string Make { get; set; } // Марка
        public string Color { get; set; } // Цвет
        public double CurrentSpeed { get; private set; } // Текущая скорость

        private const double MaxSpeed = 180.0; // Максимально допустимая скорость

        // Конструктор по умолчанию
        public Car()
        {
            LicensePlate = "Неизвестно";
            Make = "Неизвестно";
            Color = "Неизвестно";
            CurrentSpeed = 0.0;
        }

        // Конструктор с параметрами
        public Car(string licensePlate, string make, string color, double currentSpeed)
        {
            LicensePlate = licensePlate;
            Make = make;
            Color = color;
            CurrentSpeed = currentSpeed < 0 ? 0 : currentSpeed; // Скорость не может быть отрицательной
        }

        // Метод для имитации равномерного ускорения скорости автомобиля
        public void Accelerate(double increase)
        {
            if (increase < 0)
            {
                throw new ArgumentException("Увеличение скорости не может быть отрицательным.");
            }

            CurrentSpeed += increase;

            if (CurrentSpeed > MaxSpeed)
            {
                Console.WriteLine($"Скорость превышена! Автомобиль останавливается.");
                CurrentSpeed = 0; // Остановка автомобиля при превышении скорости
            }

            Console.WriteLine($"Текущая скорость автомобиля: {CurrentSpeed} км/ч");
        }

        // Метод для торможения
        public void Brake()
        {
            if (CurrentSpeed > 0)
            {
                Console.WriteLine("Торможение...");
                CurrentSpeed = 0; // Остановка автомобиля
                Console.WriteLine("Автомобиль остановлен.");
            }
        }
    }
}
