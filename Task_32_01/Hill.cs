using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Hill
    { 
        // Создал препятствие в виде Холма
        public string Name => "Холм";
        public void SlowDown(Kolobok kolobok)
        {
            Console.WriteLine($"Колобок с трудом катится вверх на {Name}!");
            kolobok.ReduceSpeed(1);
        }
    }
}