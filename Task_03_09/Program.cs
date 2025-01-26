namespace Task_03_09
{
    internal class Program
    {/*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
        отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
        менее y рублей.
        Примеры
        входные данные
        100
        10
        200
        выходные данные
        8*/
        static void Main(string[] args)
        {
            double a, b, c, year = 0;
            Console.WriteLine("Введите сумму вклада");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.WriteLine("Введите процентное увеличение");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.WriteLine("Введите конечный вклад");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Ошибка ввода");
            }
            for (double i = a; a <= c; a += a * b / 100)
            {
                a = Math.Floor(a);
                ++year;
            }
            Console.Clear();
            Console.WriteLine(year);
       
        }
    }
}
