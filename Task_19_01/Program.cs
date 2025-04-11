using System.Security.Cryptography.X509Certificates;

namespace Task_19_01
{
    internal class Program
    { /* 1. Напишите программу, в которой пользователь вводит произвольный текст в консоли,
       * после чего программа запрашивает подстроку для поиска 
       * Если подстрока найдена - то программа запрашивает текст для того чтобы заменить на него эту подстроку
       * (столько раз, сколько раз подстрока встречена в тексте)*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine(); // текст введенный пользователем 

            Console.WriteLine("Введите подстроку для поиска:");
            string text1 = Console.ReadLine(); // элемент замены
            if (text.Contains(text1))  // используем цикл  и строку Conts
            {
                Console.WriteLine("Введите подстроку для замены:");
               string text2 = Console.ReadLine(); //  новый элемент 

                string resulttext = text.Replace(text1, text2); // испл строку Replace, выводим результат
                Console.WriteLine($"Результат: { resulttext}");
            }
            else
            {
                Console.WriteLine("В тексте нет данного выражения");
            }
        }
    }
}
