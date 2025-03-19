using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    public class User
    {
        // Статическое свойство для получения
        private static User _currentUser;

        public string Name { get; set; } // Имя пользователя

        // Статическое свойство для возврата
        public static User CurrentUser
        {
            get { return _currentUser; }
        }

        // Метод для установки 
        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }

        // Конструктор
        public User(string name)
        {
            Name = name;
        }
    }
}

