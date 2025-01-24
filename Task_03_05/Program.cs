namespace Task_03_05
{
    internal class Program
    {/* Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
время работы программы */
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон изменения температуры в градусах Цельсия и шаг изменения температуры.(числами)\n");
            double one, two, three;
            Console.WriteLine("Введите начало диапазона температуры");
            while (!double.TryParse(Console.ReadLine(), out one))
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз");
            }
            Console.WriteLine("Введите конец диапазона температуры");
            while (!double.TryParse(Console.ReadLine(), out two))
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз");
            }
            Console.WriteLine("Введите шаг");
            while (!double.TryParse(Console.ReadLine(), out three))
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз");
            }
            Console.Clear();
            for (double i = one; one + three <= two + three; one += three)
            {
                Console.WriteLine(one + " С' = " + (one * 1.8 + 32) + " F'");
            }

        }
    }
}
