namespace Task_11_05
{
    internal class Program
    { /* Комбинирование ref и out: 
       * Напишите метод, который принимает два числа по ссылке (ref)
       * и возвращает их сумму и произведение через выходные параметры (out).*/
        static void Main(string[] args)
        {
            int x = 10;
            int y = 100;
            int summResult, productResult;
            SummAndProduct(ref x, ref y, out summResult, out productResult);
            Console.WriteLine($"Сумма: {summResult}");
            Console.WriteLine($"Произведение: {productResult}");
        }
        static void SummAndProduct( ref int a, ref int b, out int summ, out int product)
        {
            summ = a + b; // вычисление суммы 
            product = a * b; // вычисление произведения
        }
    }
}
