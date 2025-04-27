namespace Task_32_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();

            // Добавил в список встречи препятствия между животными
            List<object> encounters = new List<object>
            {
               new Hare(),
               new Mud(), // Грязь
               new Wolf(),
               new Hill(), // Холм
               new Bear(),
               new Fox()
            };

            foreach (var encounter in encounters)
            {
                if (!kolobok.IsAlive)
                    break;

                kolobok.Roll();

                if (encounter is Animal animal)
                {
                    kolobok.MeetAnimal(animal);
                }
                // Добавил условие 
                else if (encounter is Mud mud)
                {
                    mud.SlowDown(kolobok);
                }
                else if (encounter is Hill hill)
                {
                    hill.SlowDown(kolobok);
                }
            }

            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }
    }
}