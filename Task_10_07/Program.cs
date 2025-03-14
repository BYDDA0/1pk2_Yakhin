namespace Task_10_07
{
    internal class Program
    { /* Создайте метод с помощью которого можно сгенерировать 
       * и вернуть символьный двумерныймассив(состоящийиз символов русского алфавита)
       * и выведите на консоль данный массив с помощью другого метода(который принимает данный массив в качестве параметра) */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива n: ");
            int n = int.Parse(Console.ReadLine());

            char[,] charArray = GenerateCharArray(n);
            PrintCharArray(charArray);
        }

        // Метод для генерации символьного двумерного массива
        static char[,] GenerateCharArray(int n)
        {
            char[,] array = new char[n, n];
            Random random = new Random();

            // Генерируем символьный массив из букв русского алфавита (от 'А' до 'Я')
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = (char)random.Next('А', 'Я' + 1); // Генерируем случайную букву
                }
            }

            return array;
        }

        // Метод для вывода символьного массива на консоль
        static void PrintCharArray(char[,] array)
        {
            int n = array.GetLength(0); // Получаем размерность массива

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(); // Переходим на следующую строку после вывода строки массива
            }
        }
    }
}
