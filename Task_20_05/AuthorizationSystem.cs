using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    enum AccessLevel
    {
        Guest,      // Только чтение
        User,       // Чтение + комментарии
        Moderator,  // Удаление контента Чтение + комментарии
        Admin       // Полный доступ
    }

    class AuthorizationSystem
    {
        public static void CheckPermission(AccessLevel userLevel, string action)
        {
            bool hasAccess = false;
            string requiredLevel = "";

            // Настройка доступа для пользователей
            switch (action.ToLower())
            {
                case "read":
                    hasAccess = true; // Чтение (гость и все остальные пользователи)
                    requiredLevel = "Guest+";
                    break;

                case "comment":
                    hasAccess = userLevel >= AccessLevel.User; // Комент (пользователь и выше)
                    requiredLevel = "User+";
                    break;

                case "delete":
                    hasAccess = userLevel >= AccessLevel.Moderator; // Удаление (модератор и выше)
                    requiredLevel = "Moderator+";
                    break;

                case "admin":
                    hasAccess = userLevel == AccessLevel.Admin; // админка (админ и выше)
                    requiredLevel = "Admin";
                    break;

                default:
                    Console.WriteLine($"Неизвестное действие: {action}");
                    return;
            }

            if (hasAccess)
            {                
                Console.WriteLine($"Доступ разрешен: {userLevel} может выполнить '{action}'");       
            }
            else
            {                
                Console.WriteLine($"Ошибка: Недостаточно прав! ({userLevel} < {requiredLevel})");                
            }
        }
    }
}
