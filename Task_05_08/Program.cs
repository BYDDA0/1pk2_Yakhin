namespace Task_05_08
{
    internal class Program
    { /*Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл.
       * Создать новый массив, который будетпроизведением двух предыдущих
       * (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их врезультирующий массив)
       * Вывести результирующий массив */
        static void Main(string[] args)
        {
            // Размер массива
            int size = 10;

            // Создаем два двумерных массива 
            int[,] array1 = new int[size, size];
            int[,] array2 = new int[size, size];
            int[,] resultA = new int[size, size];

            Random random = new Random();

            // Заполняем первый массив случайными числами от 1 до 9
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array1[i, j] = random.Next(1, 10);
                }
            }

            // Заполняем второй массив случайными числами от 1 до 9
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array2[i, j] = random.Next(1, 10);
                }
            }

            // Вычисляем произведение элементов двух массивов
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    resultA[i, j] = array1[i, j] * array2[i, j];
                }
            }

            // Выводим результирующий массив
            Console.WriteLine("Результирующий массив (произведение двух массивов):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(resultA[i, j].ToString().PadLeft(4)); // Форматируем вывод
                }
                Console.WriteLine();
            }
        }
    }
}
