using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02
{
    internal class Cat
    {
        // Свойства класса Cat
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public bool IsHungry { get; private set; }

        // Конструктор класса Cat
        public Cat(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
            IsHungry = true; // По умолчанию, кот голоден
        }

        // Метод для издания звука
        public void Meow()
        {
            Console.WriteLine($"{Name} говорит: Мяу!");
        }

        // Метод для кормления кота
        public void Feed()
        {
            IsHungry = false;
            Console.WriteLine($"{Name} покормлен.");
        }

        // Метод для игры с котом
        public void Play()
        {
            Console.WriteLine($"{Name} играет с мышкой.");
        }
    }
}
