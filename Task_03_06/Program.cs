namespace Task_03_06
{
    internal class Program
    { /* Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|
       * для -4≤x≤4,
       * с шагом h = 0,5.*/
        static void Main(string[] args)
        {
            double a = -4, b = 4, x = 0.5;
            Console.WriteLine("x                y");
            Console.WriteLine("____________________");
            for ( double i = a; a <= b; a += x)
                Console.WriteLine(a + "                " + Math.Round(Math.Abs(a), 1));
        }
    }
}
