namespace Task_12_02
{
    internal class Program
    {/* создайте проект с классом Cat и Dog,
      * полностью самостоятельно продумайте данные для объектовкласса и ихфункционал */
        static void Main(string[] args)
        {
            {
                // Создаем объект для кота
                Cat cat = new Cat("Мурзик", 7, "Черный");
                cat.Meow();
                cat.Play();
                if (cat.IsHungry)
                {
                    cat.Feed();
                }

                // Создаем объект для собаки
                Dog dog = new Dog("Бобик", 5, "Овчарка");
                dog.Bark();
                dog.Walk();
                if (dog.IsHungry)
                {
                    dog.Feed();
                }

                // Информация о животных
                Console.WriteLine($"{cat.Name}, {cat.Age} лет, цвет: {cat.Color}, голоден: {cat.IsHungry}");
                Console.WriteLine($"{dog.Name}, {dog.Age} лет, порода: {dog.Breed}, голоден: {dog.IsHungry}");
            }
        }
    }
}
