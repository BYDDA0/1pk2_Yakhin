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
            // Запрос числа n у пользователя
            Console.Write("Введите размерность массива n (n*n): ");
            int n = int.Parse(Console.ReadLine());

            // Создание квадратного массива
            int[,] array = new int[n, n];
            Random random = new Random();

            // Заполнение массива случайными числами от 10 до 99
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(10, 100); 
                }
            }

            // Поиск минимального элемента
            int minValue = array[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                    }
                }
            }

            Console.WriteLine($"Минимальный элемент в массиве: {minValue}");

            // Умножение массива на минимальный элемент
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] *= minValue;
                }
            }

            // Поиск пяти максимальных значений
            int[] maxval = new int[5];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Проверка на наличие максимального значения
                    for (int k = 0; k < maxval.Length; k++)
                    {
                        if (array[i, j] > maxval[k])
                        {
                            // Сдвигаем все меньшие значения
                            for (int l = maxval.Length - 1; l > k; l--)
                            {
                                maxval[l] = maxval[l - 1];
                            }
                            maxval[k] = array[i, j];
                            break;
                        }
                    }
                }
            }

            // Вывод массива с выделением пяти максимальных значений
            Console.WriteLine("\nМассив после умножения на минимальный элемент:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool ismaxval = false;
                    for (int k = 0; k < maxval.Length; k++)
                    {
                        if (array[i, j] == maxval[k])
                        {
                            ismaxval = true;
                            break;
                        }
                    }

                    if (ismaxval)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Выделяем цветом
                        Console.Write(array[i, j] + "\t");
                        Console.ResetColor(); // Сброс цвета
                    }
                    else
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }

        }
        
    }
}

