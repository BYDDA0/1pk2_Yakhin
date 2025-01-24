namespace Task_02_04
{
    internal class Program
    {
        /*       Пользователь вводит свою дату рождения построчно(сначала год, потом месяц и в конце дату) произведите
    расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
    этом*/
        static void Main(string[] args)
        {
            int yearbirt, monthbirt, daybirt, year, month, day;
            Console.WriteLine("Введите свой год рождения");
            while (!int.TryParse(Console.ReadLine(), out yearbirt))
            {
                Console.WriteLine("Некорректный ввод, введите год рождения в виде числа");
            }

            Console.WriteLine("Введите свой месяц рождения(числом)");
            while (!int.TryParse(Console.ReadLine(), out monthbirt))
            {
                Console.WriteLine("Некорректный ввод, введите месяц рождения в виде числа");
            }
            Console.WriteLine("Введите свой день рождения");
            while (!int.TryParse(Console.ReadLine(), out daybirt))
            {
                Console.WriteLine("Некорректный ввод, введите день рождения в виде числа");
            }
            Console.WriteLine("Введите текущий год");
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Некорректный ввод, введите текущий год  в виде числа");
            }
            Console.WriteLine("Введите текущий месяц(числом)");
            while (!int.TryParse(Console.ReadLine(), out month))
            {
                Console.WriteLine("Некорректный ввод, введите текущий месяц в виде числа");
            }

            Console.WriteLine("Введите текущий день");
            while (!int.TryParse(Console.ReadLine(), out day))
            {
                Console.WriteLine("Некорректный ввод, введите текущий день в виде числа");
            }

            int Age = year - yearbirt;
            if ((month < monthbirt & Age == 18) || (month == monthbirt & day < daybirt))
                Age -= 1;
            if (Age >= 18)
                Console.WriteLine("Вы совершеннолетний");
            else
                Console.WriteLine("Вы несовершеннолетний");

        }
    }
}
