namespace Task_14_04
{
    internal class Program
    {/* Определите класс User, который будет иметь статическое свойство CurrentUser,
      * представляющее текущего пользователя, 
      * и метод для его установки */
        static void Main(string[] args)
        {
            // Создаем  пользователей
           
            User user1 = new User("Егор Петросянов");
            User user2 = new User("Сергей Булкин");
            User user3 = new User("Петя Пирожков");
           
            // Вывод пользователей
            User.SetCurrentUser(user1);
            Console.WriteLine($"Текущий пользователь: {User.CurrentUser.Name}");

            
            User.SetCurrentUser(user2);
            Console.WriteLine($"Текущий пользователь: {User.CurrentUser.Name}");
            
            User.SetCurrentUser(user3);
            Console.WriteLine($"Текущий пользователь: {User.CurrentUser.Name}");
        }
    }
}
