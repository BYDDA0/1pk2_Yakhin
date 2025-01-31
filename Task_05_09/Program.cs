namespace Task_05_09
{
    internal class Program

    {
       /* Дан квадратный массив размерность n* n.
        * Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей 
        * (это матрица, где все недиагональные элементы меньше нуля)
        * Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали.
        * Если не выполняется, товывести сообщение что данная матрица не является Z-матрицей */
        static void Main(string[] args)
        {
            // Ввод размерности матрицы
            Console.Write("Введите размерность матрицы n (n*n): ");
            int n = int.Parse(Console.ReadLine());

            // Создаем квадратный массив
            int[,] matritsa = new int[n, n];

            // Ввод элементов матрицы
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write($"Элемент [{i},{j}]: ");
                    matritsa[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Проверяем, является ли матрица Z-матрицей
            bool isZMatritsa = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matritsa[i, j] >= 0) // Проверяем недиагональные элементы
                    {
                        isZMatritsa = false;
                        break;
                    }
                }
                if (!isZMatritsa)
                    break;
            }

            // Выводим результат
            if (isZMatritsa)
            {
                Console.WriteLine("Данная матрица является Z-матрицей:");
                PrintMatrixWithDiagonalHighlight(matritsa);
            }
            else
            {
                Console.WriteLine("Данная матрица не является Z-матрицей.");
            }
        }

        static void PrintMatrixWithDiagonalHighlight(int[,] matritsa)
        {
            int n = matritsa.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        // Цвет для главной диагонали
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{matritsa[i, j],4} ");
                        Console.ResetColor(); // Сброс цвета
                    }
                    else
                    {
                        // Цвет для недиагональных элементов
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{matritsa[i, j],4} ");
                        Console.ResetColor(); // Сброс цвета
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
