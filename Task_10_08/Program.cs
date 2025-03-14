namespace Task_10_08
{
    internal class Program
    { /* Создайте метод, который на вход принимает одномерный массив
       * и число для поиска, верните индексискомогоэлемента в массиве.
       * Если элемента нет – верните индекс = -1 */
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 6, 7, 9, 11 }; // Пример одномерного массива
            Console.Write("Введите число для поиска: ");
            int number = int.Parse(Console.ReadLine());

            int index = FindElementIndex(array, number);

            if (index != -1)
            {
                Console.WriteLine($"Число {number} найдено по индексу {index}.");
            }
            else
            {
                Console.WriteLine($"Число {number} не найдено в массиве.");
            }
        }

        // Метод для поиска индекса элемента в массиве
        static int FindElementIndex(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i; // Возвращаем индекс найденного элемента
                }
            }
            return -1; // Если элемент не найден, возвращаем -1
        }
    }

}
