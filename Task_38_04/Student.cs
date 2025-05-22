using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_04
{
    class Student : IComparable
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public DateTime Birthday { get; private set; }
        public string Group { get; private set; }
        public StudentFlour Flour { get; private set; }

        public Student(string name, string surname, string patronymic, string group, DateTime birthday, StudentFlour flour)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Group = group;
            Birthday = birthday;
            Flour = flour;
        }

        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic}";
        }

        public string FlourOfStudent()
        {
            switch (Flour)
            {
                case StudentFlour.Male: return "Мужской"; break;
                case StudentFlour.Female: return "Женский"; break;
            }
            return null;
        }

        public int CompareTo(object? obj)
        {
            if (obj != null && obj is Student student)
            {
                return (Surname + Name).CompareTo(student.Surname + student.Name);
            }
            else
                throw new NotImplementedException();
        }


    }
}
