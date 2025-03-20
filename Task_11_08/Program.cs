namespace Task_11_08
{
    internal class Program
    { /* Использование params и out:
       * Напишите метод, который принимает переменное количество чисел
       * и возвращает их сумму 
       * и максимальное значение через выходные параметры (out).*/
        static void Main(string[] args)
        {
            int summResult, maxResult;
            // Вызов метода
            SumAndMax( out summResult, out maxResult, 1,2,3);
            Console.WriteLine($"сумма: {summResult}, максимальное значение: {maxResult}");
            SumAndMax(out summResult, out maxResult, 10, 20, 30);
            Console.WriteLine($"сумма: {summResult}, максимальное значение: {maxResult}");
            SumAndMax(out summResult, out maxResult, 17, 41, 143);
            Console.WriteLine($"сумма: {summResult}, максимальное значение: {maxResult}");
        }
        // Метод для вычисления
        static void SumAndMax(out int summ, out int max, params int[] numbers)
        {
            summ = 0; 
            max = numbers.Length > 0 ? numbers[0] : 0; 
           // Цикл для вычисления суммы и макс
            for (int i = 0; i < numbers.Length; i++)
            {
                summ += numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
            }
        }
    }
}
