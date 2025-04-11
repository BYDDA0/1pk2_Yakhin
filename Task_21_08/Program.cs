namespace Task_21_08
{
    internal class Program
    { /* напишите метод, который на вход получается массив параметров (строк)
       * и возвращает только уникальные строки*/
        static void Main(string[] args)
        {
            string[] eat = { "яблоко", "груша", "яблоко", "апельсин", "банан" };

            string[] array = GetUniqueStrings(eat);

            Console.WriteLine("Исходный массив: " + string.Join(", ", eat));
            Console.WriteLine("Уникальные строки: " + string.Join(", ", array));
        }

        // Метод для уникальных строк
        static string[] GetUniqueStrings(string[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
                return Array.Empty<string>();

            List<string> result = new List<string>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool Duplicate = false;

                // Проверка, встречалась ли слово ранее в массиве
                for (int j = 0; j < i; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        Duplicate = true;
                        break;
                    }
                }

                if (!Duplicate)
                {
                    result.Add(inputArray[i]);
                }
            }

            return result.ToArray();
        }
    }
}