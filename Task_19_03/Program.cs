namespace Task_19_03
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            string line;
            Console.WriteLine("Введите строку:" + 
                "\n(Для завершения ввода введите пустую строку)");
            while (true)
            {
                line = Console.ReadLine();
                // проверка на не пустую строку 
                if (String.IsNullOrWhiteSpace(line)) 
                {
                    break;
                }
                // добавляем "-" после каждого слова
                if (result.Length > 0) 
                {
                    result += "-";
                }
                result += line;
                Console.WriteLine($"Результат: \"{result}\"");
            }
        }
    }
}
