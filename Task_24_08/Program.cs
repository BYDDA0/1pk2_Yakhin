using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Task_24_08
{
    internal class Program
    { /* реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенные пользователем*/
#pragma warning disable
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ренат\source\repos\1pk2_Yakhin\Task_24_08\bin\Debug\net8.0\text.txt";
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
                Console.WriteLine("Введите текст который хотите заменить:");
                string replacementText = Console.ReadLine();
                Console.WriteLine("Введите текст который вы хотите добавить:");
                string addText = Console.ReadLine();
                ReplaceText(path, replacementText, addText);
            }
        }
        //  Заменяет текст на заданное значение 
        public static void ReplaceText(string path, string firstText, string addText)
        {
            string text;
            using (StreamReader read = new StreamReader(path))
            {
                text = read.ReadToEnd();
            }
            string newText = text.Replace(firstText, addText);
            Console.WriteLine("\n" + newText);
        }
    }
}



