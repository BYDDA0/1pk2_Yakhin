using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    internal class Pet
    {
        // Свойства
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsHealthy { get; set; } // true - здоров, false - нездоров

        // Конструктор по умолчанию
        public Pet()
        {
            Name = "Неизвестно";
            Species = "Неизвестно";
            Age = 0;
            Weight = 0.0;
            IsHealthy = true;
        }

        // Конструктор с параметрами
        public Pet(string name, string species, int age, double weight, bool isHealthy)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            IsHealthy = isHealthy;
        }

        // Метод для вывода информации об объекте
        public void DisplayInfo()
        {
            Console.WriteLine($"Кличка: {Name}");
            Console.WriteLine($"Вид: {Species}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Вес: {Weight} кг");
            Console.WriteLine($"Состояние здоровья: {(IsHealthy ? "Здоров" : "Нездоров")}");
        }

        // Метод для изменения веса животного
        public void ChangeWeight(double newWeight)
        {
            Weight = newWeight;
        }

        // Метод для изменения отметки о состоянии здоровья
        public void ChangeHealthStatus(bool isHealthy)
        {
            IsHealthy = isHealthy;
        }
    }
}