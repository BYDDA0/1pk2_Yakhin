namespace Task_11_02
{
    internal class Program
    { /* Передача по ссылке (ref):
       * Напишите метод, который принимает два целых числа по ссылке  и меняет их местами.
       * Проверьте, изменились ли значения переменных вне метода */
        static void Swap( ref int a, ref int b)
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
            Swap(ref x, ref y);
            Console.WriteLine($"После обмена мест: x= {y}, y = {x}");
        }
    }
}
