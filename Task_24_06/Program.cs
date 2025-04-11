using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.IO;

namespace Task_24_06
{
    internal class Program
    { /* Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. 
       * ИспользуйтеStreamReader.*/
#pragma warning disable
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ренат\source\repos\1pk2_Yakhin\Task_24_06\bin\Debug\net8.0\text.txt";
            string text = "Дела давно минувших дней,\n" +
                "Преданья старины глубокой.\n" +
                "В толпе могучих сыновей,\n" +
                "С друзьями, в гриднице высокой\n" +
                "Владимир-солнце пировал;\n" +
                "Меньшую дочь он выдавал\n" +
                "За князя храброго Руслана\n" +
                " мед из тяжкого стакана\n" +
                "За их здоровье выпивал.";

            // Создание текстового документа
            FileInfo fileInfo = new FileInfo(path);

            File.Create(path).Dispose();
            File.WriteAllText(path, text);
            
            // Вывод на консоль + проверка условия
            if (!File.Exists(path))
            {
                Console.WriteLine($"Папки {fileInfo.Name} не существует по указанному пути");
            }
            else
            {
                Console.WriteLine($"Количество строк в файле: {fileInfo.Name} по пути {path} - {GetCountOfLinesOfText(path)}");
            }
        }

        // Возврат строк в файле
        public static int GetCountOfLinesOfText(string path)
        {
            int count = 0;
            using (StreamReader Read = new StreamReader(path))
            {
                string line;
                while ((line = Read.ReadLine()) != null)
                    count++;
                return count;
            }
        }
    }
}
