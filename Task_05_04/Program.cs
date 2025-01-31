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
            int n = 3; // Размерность матрицы
            int[,] matritsa = {
            { 1, 0, 0 },
            { 0, 2, 0 },
            { 0, 0, 3 }
        };

            if (IsDiagonalMatrix(matritsa, n))
            {
                Console.WriteLine("Матрица является диагональной:");
                DisplayMatrixWithDiagonalHighlight(matritsa, n);
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной.");
            }
        }

        static bool IsDiagonalMatrix(int[,] matritsa, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matritsa[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void DisplayMatrixWithDiagonalHighlight(int[,] matritsa, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        // Выделяем элементы главной диагонали
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(matritsa[i, j] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matritsa[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
