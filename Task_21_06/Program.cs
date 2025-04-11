using System;
using System.Globalization;

namespace Task_21_06
{
    internal class Program
    { /* Написать метод, который удаляет повторяющиеся элементы из списка, 
       * сохраняя порядок. */
#pragma warning disable
        static List<number> RemoveDuplicates<number>(List<number> list)
        {
            var result = new List<number>();
            foreach (var i in list)
            {
                if (!result.Contains(i))
                    result.Add(i);
            }
            return result;
        }
        
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 2, 4, 1, 5, 4, 1, 6, 7};
            var uniqueNumbers = RemoveDuplicates(numbers);

            Console.WriteLine("Исходный список: " + string.Join(", ", numbers));
            Console.WriteLine("Список без повторений: " + string.Join(", ", uniqueNumbers));
        }
    }
}