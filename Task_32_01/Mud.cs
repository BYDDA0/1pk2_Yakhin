using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Mud
    {
        // Создал препятствие в виде Грязи
        public string Name => "Грязь";
        public void SlowDown(Kolobok kolobok)
        {
            Console.WriteLine($"Колобок застрял в {Name}!");
            kolobok.ReduceSpeed(1);
        }
    }
}