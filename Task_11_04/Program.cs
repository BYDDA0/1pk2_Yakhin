using System.Threading.Channels;

namespace Task_11_04
{ /* Массив параметров (params):
   * Напишите метод, который принимает массив чисел
   * и возвращает их среднее значение.
   * Используйте ключевое слово params*/
    internal class Program
    {
        static void Main(string[] args)
        {
           double Averagе = AveragеValue(1, 2, 3, 4, 5, 6, 7);
            double Averagе2 = AveragеValue(10, 20, 30, 40, 50, 60, 70);
            double Averagе3 = AveragеValue(11, 52, 62, 94, 39, 24, 21);
            Console.WriteLine($"среднее значение: {Averagе}");
            Console.WriteLine($"среднее значение: {Averagе2}");
            Console.WriteLine($"среднее значение: {Averagе3}");
        }
        
        static double AveragеValue (params int [] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            int summ = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                summ += numbers[i];
            }
            return summ / numbers.Length;
        }
    }
}
