namespace Task_20_05
{
    internal class Program
    { /* Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
       * Guest (только чтение)
       * User (чтение + комментарии)
       * Moderator (удаление контента)
       * Admin (полный доступ)
       * Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).
       * На основе уровня доступа выводите сообщение (например, "Ошибка: Недостаточно прав!")*/
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование системы авторизации\n");

            // Проверка всех пользователей 
            TestAccess(AccessLevel.Guest);
            TestAccess(AccessLevel.User);
            TestAccess(AccessLevel.Moderator);
            TestAccess(AccessLevel.Admin);
        }

        static void TestAccess(AccessLevel level)
        {
            Console.WriteLine($"\n=== Тест для уровня: {level} ===");
            AuthorizationSystem.CheckPermission(level, "read");
            AuthorizationSystem.CheckPermission(level, "comment");
            AuthorizationSystem.CheckPermission(level, "delete");
            AuthorizationSystem.CheckPermission(level, "admin");
        }
    }
}
