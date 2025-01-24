namespace Task_03_04
{
    internal class Program
    {   /* Пользователь вводить в консоли произвольный текст. 
         * После каждого ввода консоль очищается. 
         * Когда пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк введенных пользователем.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Для прекращения ввода введите слово «exit» или пустую строку");
            string q = Console.ReadLine();
            int w = 0; 
            while (true) 


            {   
                ++w;
                Console.Clear();
                q = Console.ReadLine();
                if (q == "exit" | q == "")
                    break;
            }
             Console.Clear() ;
            Console.WriteLine("Было введено" + w + "строк(и)");

        }
    }
}
