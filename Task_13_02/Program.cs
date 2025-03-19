﻿namespace Task_13_02
{
    internal class Program
    {/* создать класс питомца 
      * свойства: 
      * кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров) 
      * методы: 
      * вывод информации об объекте 
      * изменение значения веса животного 
      * изменение отметки о состоянии здоровья 
      * конструторы: 
      * предусмотрите разные варианты инициализации объектов*/
        static void Main(string[] args)
        {
            // Создание питомца с помощью конструктора с параметрами
            Pet myPet = new Pet("Бобик", "Собака", 5, 20.5, true);
            myPet.DisplayInfo();

            Console.WriteLine("\nПоменял вес и состояние здоровья...");
            myPet.ChangeWeight(29.0);
            myPet.ChangeHealthStatus(false);

            // Вывод обновленной информации
            myPet.DisplayInfo();
        }
    }
}
