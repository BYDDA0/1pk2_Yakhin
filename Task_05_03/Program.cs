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
        static void Main()
        {
            // Создаем две матрицы размером 3x3 
            char[,] matritsa1 = new char[3, 3];
            char[,] matritsa2 = new char[3, 3];

            // Заполняем первую матрицу
            Console.WriteLine("Введите элементы первой матрицы (3x3):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matritsa1[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            // Заполняем вторую матрицу
            Console.WriteLine("\nВведите элементы второй матрицы (3x3):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matritsa2[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            // Проверяем, равны ли они
            bool areEqual = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matritsa1[i, j] != matritsa2[i, j])
                    {
                        areEqual = false;
                        break;
                    }
                }
                if (!areEqual) break;
            }

            // Выводим результат проверки
            if (areEqual)
            {
                Console.WriteLine("\nМатрицы равны.");
            }
            else
            {
                Console.WriteLine("\nМатрицы не равны. Выводим элементы с индикацией равных элементов:");

                // Выводим обе матрицы с индикацией равных элементов
                Console.WriteLine("\nПервая матрица:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matritsa1[i, j] == matritsa2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // Зеленый для равных элементов
                            Console.Write(matritsa1[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matritsa1[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nВторая матрица:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matritsa1[i, j] == matritsa2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // Зеленый для равных элементов
                            Console.Write(matritsa2[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matritsa2[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
} 







