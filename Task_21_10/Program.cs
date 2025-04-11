namespace Task_21_10
{
    internal class Program
    { /* Написать метод, который объединяет два словаря.
       * Если ключ присутствует в обоих словарях, суммировать их значения.*/
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary1 = new Dictionary<string, int>
        {
            { "машина", 2 },
            { "велик", 8 },
            { "дверь", 5 }
        };

            Dictionary<string, int> dictionary2 = new Dictionary<string, int>
        {
            { "машина", 2 },
            { "велик", 4 },
            { "вертолет", 1 }
        };

            Dictionary<string, int> mergedDict = MergeDictionaries(dictionary1, dictionary2);

            Console.WriteLine("Объединенный словарь:");
            foreach (KeyValuePair<string, int> pair in mergedDict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
       
        static Dictionary<string, int> MergeDictionaries(
        Dictionary<string, int> dictionary1,
        Dictionary<string, int> dictionary2)
        {
            // Создаем новый словарь для результата
            Dictionary<string, int> result = new Dictionary<string, int>();

            // Сумируем 1 и 2 словари
            foreach (KeyValuePair<string, int> pair in dictionary1)
            {
                result[pair.Key] = pair.Value;
            }            
            foreach (KeyValuePair<string, int> pair in dictionary2)
            {
                if (result.ContainsKey(pair.Key))
                {
                    // Если ключ уже есть суммируем значения
                    result[pair.Key] = result[pair.Key] + pair.Value;
                }
                else
                {
                    // Если ключа нет не сумируем
                    result[pair.Key] = pair.Value;
                }
            }

            return result;
        }
    }
}
      