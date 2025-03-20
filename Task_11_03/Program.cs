namespace Task_11_03
{
    internal class Program
    { /* Выходной параметр (out): 
       * Напишите метод, который принимает строку
       * и возвращает через выходной параметр количество гласных 
       * и согласных букв в этой строке */

        static void Main(string[] args)
        {
            {
                string text = "привет как у тебя дела?";
                int glasn, soglas; // гласные,согласные

                // Вызов метода 
                CountVowelsAndConsonants(text, out glasn, out soglas);
                // вывод
                Console.WriteLine($"Текст: {text}");
                Console.WriteLine($"Гласные: {glasn}");
                Console.WriteLine($"Согласные: {soglas}");
            }
            // Метод
            static void CountVowelsAndConsonants(string input, out int glasnCount, out int soglasCount)
            {
                glasnCount = 0;
                soglasCount = 0;
                // цикл
                foreach (char sog in input)
                {
                    if (char.IsLetter(sog))
                    {
                        if ("aeiouаеёиоуыэюя".Contains(sog)) // подсчет гласных 
                        {
                            glasnCount++;
                        }
                        else // подсчет согласных
                        {
                            soglasCount++;
                        }
                    }
                }
            }
        }
    }
}