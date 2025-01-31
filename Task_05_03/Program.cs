namespace Task_05_03
{
    internal class Program
    {
       /* Даны два массива, заполненные символами английского алфавита размером 3*3.
        * Проверить, являются ли матрицы равными, если
        * да, то вывести сообщение о том, что они равны, если нет,
        * то вывести повторно матрицы с цветовой индикацией только тех
        * элементов, которые равны
       . (матрицы считаются равными, если их соответствующие элементы равны. */
        static void Main(string[] args)
        {
            char[,] matritsa1 = {
            { 'f', 'h', 'h' },
            { 'f', 'c', 'h' },
            { 'w', 'g', 'k' }
        };

            char[,] matritsa2 = {
            { 'f', 'h', 'h' },
            { 'f', 'c', 'x' },
            { 'a', 'f', 'j' }
        };

            bool bi = CompareMatrices(matritsa1, matritsa2);

            if (bi)
            {
                Console.WriteLine("Матрицы равны");
            }
            else
            {
                Console.WriteLine("Матрицы не равны");
                DisplayMatrices(matritsa1, matritsa2);
            }
        }

        static bool CompareMatrices(char[,] matritsa1, char[,] matritsa2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matritsa1[i, j] != matritsa2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void DisplayMatrices(char[,] matritsa1, char[,] matritsa2)
        {
            Console.WriteLine("Матрицы:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matritsa1[i, j] == matritsa2[i, j])
                    {
                        // Выделяем совпадающие элементы
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(matritsa1[i, j] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        // Выводим разные элементы
                        Console.Write($"{matritsa1[i, j]} {matritsa2[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
        
    

    

