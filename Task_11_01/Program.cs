using System.Xml;

namespace Task_11_01
{ /* Передача по значению:
   * Напишите метод, который принимает два целых числа
   * и меняет их местами.
   * Проверьте, изменились ли значения переменных вне метода */
    internal class Program
    {
        static void Swap(int a, int b)
        {
           int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Console.WriteLine($"до обмена мест: x= {x}, y = {y}");
            Swap(x, y);
            Console.WriteLine($"После обмена мест: x= {y}, y = {x}");
        }
    }
}
