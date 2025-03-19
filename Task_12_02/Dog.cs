using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02
{
    internal class Dog
    {
        // Свойства класса Dog
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public bool IsHungry { get; private set; }

        // Конструктор класса Dog
        public Dog(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
            IsHungry = true; // По умолчанию собака голодна
        }

        // Метод для издания звука
        public void Bark()
        {
            Console.WriteLine($"{Name} говорит: Гав!");
        }

        // Метод для кормления собаки
        public void Feed()
        {
            IsHungry = false;
            Console.WriteLine($"{Name} покормлен.");
        }

        // Метод для прогулки с собакой
        public void Walk()
        {
            Console.WriteLine($"{Name} гуляет в парке.");
        }
    }
}