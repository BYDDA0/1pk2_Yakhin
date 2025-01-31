using System.ComponentModel.Design;

namespace Task_05_06
{
    internal class Program
    {/*Осуществить генерация двумерного [10*5] массива по следующему правилу:
      *1 столбец содержит нули
      *2 столбце содержит числа кратные 2
      *3 столбец содержит числа кратные 3
      *4 столбец содержит числа кратные 4
      *5 столбец содержит числа кратные 5
      *Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив */
        static void Main(string[] args)
        {
            // Создаем двумерный массив размером 10x5
            int[,] array = new int[10, 5];

            // Заполняем массив 
            for (int i = 0; i < 10; i++)
            {
                array[i, 0] = 0; // 1 столбец содержит 0
                array[i, 1] = (i + 1) * 2; // 2 столбец содержит числа кратные 2
                array[i, 2] = (i + 1) * 3; // 3 столбец содержит числа кратные 3
                array[i, 3] = (i + 1) * 4; // 4 столбец содержит числа кратные 4
                array[i, 4] = (i + 1) * 5; // 5 столбец содержит числа кратные 5
            }
            // Выводим исходный массив на панель
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Транспонируем массив
            int[,] transposedArray = TransposeArray(array);

            // Выводим обновленный массив на панель
            Console.WriteLine("Транспонированный массив:");
            PrintArray(transposedArray);
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(4)); // Форматируем вывод 
                }
                Console.WriteLine();
            }
        }

        static int[,] TransposeArray(int[,] array)
        {
            int naprav1 = array.GetLength(0);
            int naprav2 = array.GetLength(1);
            int[,] transposed = new int[naprav2, naprav1];

            for (int i = 0; i < naprav1; i++)
            {
                for (int j = 0; j < naprav2; j++)
                {
                    transposed[j, i] = array[i, j]; // Меняем местами строки и столбцы
                }
            }

            return transposed;

        }
          
    }
}
