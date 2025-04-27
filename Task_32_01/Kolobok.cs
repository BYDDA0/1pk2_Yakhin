using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; private set; }
        public bool IsAlive { get; private set; }
        public Kolobok()
        {
            Position = 0;
            Speed = 2; // Начальную скорость я поменял, можно поменять на любое значение не меньше 1 
            IsAlive = true;
        }
        public void Roll()
        {
            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
        }
        //встреча с животным
        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }
        // Добавил метод для изменения скорости
        public void ReduceSpeed(int amount)
        {
            Speed -= amount;
            if (Speed < 1) Speed = 1; // Минимальная скорость
            Console.WriteLine($"Скорость уменьшена до {Speed}");
        }
    }
}