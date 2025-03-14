namespace Task_10_06
{
    internal class Program
    { /* Создать Метод ArrayGeneration не возвращающий значения,
       * принимает целое число n, 
       * выводит наконсольсгенерированный массив размерности n*n. */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива n: ");
            int n = int.Parse(Console.ReadLine());

            ArrayGeneration(n);
        }

        static void ArrayGeneration(int n)
        {
            Random random = new Random();
            int[,] array = new int[n, n];

            // Заполняем массив случайными числами и выводим его
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 10); // Генерируем число от 0 до 9
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(); // Перейти на следующую строку после завершения строки массива
            }
        }
    }
}
