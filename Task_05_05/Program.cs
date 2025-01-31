namespace Task_05_05
{
    internal class Program
    { /*У пользователя в консоли запрашивается числа n и m
       * , генерируется прямоугольный массив целых числе [n*m].
       * Заполнение случайными числами в диапазоне от -99 до 99 включительно. 
       * Осуществите без создания нового массива преобразование текущегопо следующему правилу:
       * Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом 
       * Если элемент равен нулю, то перезаписываем единицу 
       * и выделяем при выводе красным цветом */
        static void Main(string[] args)
        {
            Random rdm = new Random();

            Console.Write("Введите количество строк (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n, m];

            // Заполнение массива случайными числами
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rdm.Next(-99, 100);
                }
            }

            Console.WriteLine("Преобразованный массив:");

            // Преобразование массива и вывод
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0)
                    {
                        // Отбрасываем знак и выделяем зеленым
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Math.Abs(array[i, j]) + " ");
                        Console.ResetColor();
                    }
                    else if (array[i, j] == 0)
                    {
                        // Перезаписываем на 1 и выделяем красным
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(1 + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
