namespace Task_05_07
{
    internal class Program
    { /*У пользователя в консоли запрашивается число n, 
       * генерируется квадратный массив целых числе [n*n].
       * Заполнение случайными числами в диапазоне от 10 до 99 включительно.
       * Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее минимальный элемент, 
       * при выводе цветом выделить пять максимальных значений в массиве */
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя размерность массива
            Console.Write("Введите размерность n для квадратной матрицы n*n (n > 0): ");
            int n = int.Parse(Console.ReadLine());

            // Создаем квадратный массив размером n*n
            int[,] matritsa = new int[n, n];
            Random random = new Random();

            // Заполняем массив случайными числами от 10 до 99
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matritsa[i, j] = random.Next(10, 100);
                }
            }

            // Находим минимальный элемент в матрице
            int minElement = FindMinElement(matritsa);

            // Умножаем матрицу на минимальный элемент
            MultiplyMatrixByMinElement(matritsa, minElement);

            // Выводим результат с выделением пяти максимальных значений
            Console.WriteLine($"Минимальный элемент в матрице: {minElement}");
            Console.WriteLine("Матрица после умножения на минимальный элемент:");

            PrintMatrixWithMaxHighlight(matritsa);
        }

        static int FindMinElement(int[,] matritsa)
        {
            int min = matritsa[0, 0];
            for (int i = 0; i < matritsa.GetLength(0); i++)
            {
                for (int j = 0; j < matritsa.GetLength(1); j++)
                {
                    if (matritsa[i, j] < min)
                    {
                        min = matritsa[i, j];
                    }
                }
            }
            return min;
        }

        static void MultiplyMatrixByMinElement(int[,] matritsa, int minEl)
        {
            for (int i = 0; i < matritsa.GetLength(0); i++)
            {
                for (int j = 0; j < matritsa.GetLength(1); j++)
                {
                    matritsa[i, j] *= minEl;
                }
            }
        }

        static void PrintMatrixWithMaxHighlight(int[,] matritsa)
        {
            // Находим пять максимальных значений
            int[] maxval = new int[5];

            for (int i = 0; i < matritsa.GetLength(0); i++)
            {
                for (int j = 0; j < matritsa.GetLength(1); j++)
                {
                    int currentval = matritsa[i, j];
                    // Проверяем, не является ли текущее значение одним из пяти максимальных
                    for (int k = 0; k < maxval.Length; k++)
                    {
                        if (currentval > maxval[k])
                        {
                            // Сдвигаем значения вниз
                            for (int l = maxval.Length - 1; l > k; l--)
                            {
                                maxval[l] = maxval[l - 1];
                            }
                            maxval[k] = currentval;
                            break;
                        }
                    }
                }
            }

            // Выводим матрицу с выделением максимальных значений
            for (int i = 0; i < matritsa.GetLength(0); i++)
            {
                for (int j = 0; j < matritsa.GetLength(1); j++)
                {
                    bool ismaxval = false;

                    // Проверяем, является ли текущее значение одним из пяти максимальных
                    for (int k = 0; k < maxval.Length; k++)
                    {
                        if (matritsa[i, j] == maxval[k])
                        {
                            ismaxval = true;
                            break;
                        }
                    }

                    if (ismaxval)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Устанавливаем цвет для максимальных значений
                        Console.Write(matritsa[i, j].ToString().PadLeft(4));
                        Console.ResetColor(); // Сбрасываем цвет
                    }
                    else
                    {
                        Console.Write(matritsa[i, j].ToString().PadLeft(4));
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}

