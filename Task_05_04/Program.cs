namespace Task_05_04
{
    internal class Program
    { /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы 
       * и выясните является ли данная матрица
       * диагональной (все элементы вне главной диагонали равны нулю)
       *цветовым выделением главной диагонали.
       *Если нет, то вывеси сообщение что матрица не является диагональной. */
        static void Main(string[] args)
        {
            // Ввод размерности матрицы
            Console.Write("Введите размерность матрицы n (n*n): ");
            int n = int.Parse(Console.ReadLine());

            // Создаем квадратную матрицу размером n*n
            int[,] matrix = new int[n, n];

            // Заполняем матрицу
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Проверяем, является ли матрица диагональной
            bool isDiagonal = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] != 0)
                    {
                        isDiagonal = false;
                        break;
                    }
                }
                if (!isDiagonal) break;
            }

            // Выводим результат
            if (isDiagonal)
            {
                Console.WriteLine("\nМатрица является диагональной. Выводим с выделением главной диагонали:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // Зеленый для главной диагонали
                            Console.Write(matrix[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nМатрица не является диагональной.");
            }
        }
    }
}
