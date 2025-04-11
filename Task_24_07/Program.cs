using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Task_24_07
{
    internal class Program
    { /* Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки, содержащиеэтослово (регистронезависимо).*/
#pragma warning disable
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ренат\source\repos\1pk2_Yakhin\Task_24_07\bin\Debug\net8.0\text.txt";
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
                Console.WriteLine("Введите слово которое вы ищите:");
                string textR = Console.ReadLine();
                Console.WriteLine($"Строки с заданым словом {textR}:\n {Textt(path, textR)}");
            }
        }

        // Находим строки с заданным словом
        public static string Textt(string path, string CurText)
        {
            string CurTextLine = "";
            using (StreamReader stream = new StreamReader(path))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] curline = line.Split(' ');
                    for (int i = 0; i < curline.Length; i++)
                    {
                        curline[i] = curline[i].ToLower();
                    }
                    foreach (string cur in curline)
                    {
                        if (cur == CurText.ToLower())
                            CurTextLine += line + "\n";
                    }
                }
            }
            return CurTextLine;
        }
    }
}

