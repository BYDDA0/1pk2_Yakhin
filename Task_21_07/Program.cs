namespace Task_21_07
{
    internal class Program
    { /* Написать метод, который находит первый ключ в словаре, соответствующий заданному значению.
       * Если значения нет, вернуть null.*/

#pragma warning disable

        static void Main(string[] args)
        {
            // Создаем словарь
            var dict = new Dictionary<string, int>
        {
            {"яблоко", 1},
            {"банан", 2},
            {"апельсин", 3},
            {"груша", 2}  // Дубликат значения
        };

            // Ищем ключ для значения 2
            string key = FindKey(dict, 2);
            Console.WriteLine(key ?? "Не найдено"); // Выведет "банан"

            // Ищем несуществующее значение
            key = FindKey(dict, 5);
            Console.WriteLine(key ?? "Не найдено"); // Выведет "Не найдено"
        }

        // Метод поиска ключа 
        static TKey FindKey<TKey, TValue>(Dictionary<TKey, TValue> dict, TValue value)
        {
            foreach (var item in dict)
            {
                if (item.Value.Equals(value))
                    return item.Key;
            }
            return default; // Вернет null нет значений
        }
    }
}