namespace Task_11_06
{
    internal class Program
    { /* Передача массива по значению: 
       * Напишите метод, который принимает массив целых чисел
       * и изменяет его элементы, увеличивая каждый на 1.
       * Проверьте, изменился ли оригинальный массив вне метода. */
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("оригинальный массив:");
            PrintArray(numbers);

            // Вызов метода 
            IncrementArrayElements(numbers);

            Console.WriteLine("массив после изменений:");
            PrintArray(numbers);
        }
        // Метод для изменения массива
        static void IncrementArrayElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 2; // цикл для изменения массива
            }
        }
        // Вспомогательный метод
        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
