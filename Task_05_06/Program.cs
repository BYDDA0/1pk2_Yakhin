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
            // Определяем размеры массива
            int desat = 10;
            int pat = 5;

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
            // Выводим исходный массив
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < desat; i++)
            {
                for (int j = 0; j < pat; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Создаем новый массив для транспонирования
            int[,] transposedArray = new int[pat, desat];

            // Выполняем транспонирование массива
            for (int i = 0; i < desat; i++)
            {
                for (int j = 0; j < pat; j++)
                {
                    transposedArray[j, i] = array[i, j];
                }
            }

            // Выводим транспонированный массив
            Console.WriteLine("\nТранспонированный массив:");
            for (int i = 0; i < pat; i++)
            {
                for (int j = 0; j < desat; j++)
                {
                    Console.Write(transposedArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
