namespace Task_19_02
{
    internal class Program
    { /* 2. Напишите программу, которая запрашивает у пользователя произвольный текст,
       * содержащий предложения (есть знаки препинания).
       * программу после анализа выводит текст, разделенный на части:
       * a)	По пробелам (отдельные слова построчно)
       * b)	По предложениям (отдельные предложения построчно)
        (используйте метод Split()) */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст со знаками препинания:");
            string text = Console.ReadLine();

            // а) 
            string[] textArray1 = text.Split(' '); // массив с Методом Split()

            Console.WriteLine($"\nТекст разделен по пробелам:");
            foreach (string resulttext1 in textArray1)
            {
                Console.WriteLine(resulttext1);
            }
            // б)
            string[] textArray = text.Split('!', '?', '.', ';'); // массив с Методом Split()

            Console.WriteLine($"\nТекст разделен по предложениям:"); 
            foreach (string resulttext in textArray)
            {
                Console.WriteLine(resulttext);
            }
        }
    }
}
