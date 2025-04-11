namespace Task_23_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу со следующими функциями:
             * 1. Выведите информации о всех дисках в системе
             * 2. Выведите содержимое каталога C:\Users (названия папок)
             * 3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
             * a) Создание вложенного каталога “temp”
             * b) Вывод информации о текущем каталоге (имя, родитель и тд)
             * c) Вывод информации о вложенном каталоге
             * 4. Переместите каталог “temp” по пути “D:\work\newTemp”
             * a) Реализуйте вывод информационного сообщения об успешном (или нет) перемещении
             * 5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет) удалении.*/
#pragma warning disable
            static void Main(string[] args)
            {
                // Массив с списком для вывода информации о жестком диске
                List<DriveInfo> directories = DriveInfo.GetDrives().ToList();
                Console.WriteLine("Информация о дисках в системе:");
                foreach (var item in directories)
                {
                    Console.WriteLine($"\tДиск {item.Name}\n" +
                        $"\tРазмер диска - {item.TotalSize / 1024 / 1024 / 1024}Гб,\n\t" +
                        $"Доступно места - {item.AvailableFreeSpace / 1024 / 1024 / 1024}Гб,\n\t" +
                        $"Тип диска - {item.DriveType},\n\t" +
                        $"Метка диска - {item.VolumeLabel}\n");
                }

                // Проверка существует ли католог
                Console.WriteLine(@"Cодержимое каталога C:\\Users:");
                string dir = @"C:\Users";
                if (Directory.Exists(dir))
                {
                    List<string> list = Directory.GetDirectories(dir).ToList();
                    if (list.Count > 0)
                    {
                        foreach (string item in list)
                            Console.WriteLine("\t" + item);
                    }
                    else
                        Console.WriteLine("Каталог пуст");
                }
                else
                    Console.WriteLine("Каталога не существует");

                // Создание папки "work"
                Console.WriteLine();
                string folderWork = @"C:\work";
                if (!Directory.Exists(folderWork))
                {
                    Directory.CreateDirectory(folderWork);
                    Console.WriteLine("Папка work создана\n");
                }
                else
                    Console.WriteLine($"Папка work уже существует по пути {folderWork}\n");

                string currentD = folderWork;
                string subCD = "temp";

                DirectoryInfo directoryCD = new DirectoryInfo(currentD);

                if (Directory.Exists(Path.Combine(currentD, subCD)))
                {
                    Console.WriteLine($"Вложенный каталог {subCD} уже существует\n");
                }
                else
                {
                    directoryCD.CreateSubdirectory(subCD);
                    Console.WriteLine($"Вложенный каталог {subCD} создан\n");
                }
                // Вывод информации о каталоге 
                Console.WriteLine($"Информация о текущем каталоге {directoryCD.Name}:\n" +
                    $"\tИмя - {directoryCD.Name}\n" +
                    $"\tПолное имя - {directoryCD.FullName}\n" +
                    $"\tРодительский каталог - {directoryCD.Parent} \n" +
                    $"\tКорневой каталог - {directoryCD.Root} \n" +
                    $"\tДата создания - {directoryCD.CreationTime}\n" +
                    $"\tДата последнего доступа - {directoryCD.LastAccessTime}\n" +
                    $"\tДата последнего изменения - {directoryCD.LastWriteTime}\n");

                DirectoryInfo directorySD = new DirectoryInfo(currentD + @"\" + subCD);

                Console.WriteLine($"Информация о вложенном катологе каталоге {subCD}:\n" +
                    $"\tИмя - {directorySD.Name}\n" +
                    $"\tПолное имя - {directorySD.FullName}\n" +
                    $"\tРодительский каталог - {directorySD.Parent} \n" +
                    $"\tКорневой каталог - {directorySD.Root} \n" +
                    $"\tДата создания - {directorySD.CreationTime}\n" +
                    $"\tДата последнего доступа - {directorySD.LastAccessTime}\n" +
                    $"\tДата последнего изменения - {directorySD.LastWriteTime}\n");

                // Перемещение каталога
                string path = Path.Combine(folderWork, "newTemp");
                if (Directory.Exists(Path.Combine(folderWork, "temp")))
                {
                    Directory.Move(directorySD.ToString(), path);
                    Console.WriteLine($"Успешное перемещение каталога {directorySD.Name} в {path}\n");
                }
                else
                    Console.WriteLine($"Каталог {directorySD.Name} не найден");

                // Удаление каталога
                if (Directory.Exists(Path.Combine(folderWork, "temp")))
                {
                    directorySD.Delete(true);
                    Console.WriteLine($"Каталог {directorySD.Name} удален");
                }
                else
                    Console.WriteLine($"Каталог {directorySD.Name} не удален, тк не был найден");
            }
        }
    }
}