namespace Task_21_09
{
    internal class Program
    { /* создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
       * поиск билета с максимальной суммой,
       * билета с минимальной суммой,
       * выведите список билетов с багажом
       * выведите список люготных билетов */
        static void Main(string[] args)
        {
            List<Ticket> tickets = new List<Ticket>();
            Random random = new Random();

            // Генерация списка билетов
            for (int i = 1; i <= 30; i++)
            {
                decimal price = (decimal)(random.Next(1000, 10000)); // Цена 
                bool hasLuggage = random.Next(0, 2) == 1; //  Есть багаж или нет
                bool isDiscounted = random.Next(0, 2) == 1; //  Льготный билет или нет

                tickets.Add(new Ticket(i, price, hasLuggage, isDiscounted));
            }

            // Поиск билета с максимальной и минимальной суммой
            Ticket maxPriceTicket = tickets[0];
            Ticket minPriceTicket = tickets[0];

            foreach (Ticket ticket in tickets)
            {
                if (ticket.Price > maxPriceTicket.Price)
                {
                    maxPriceTicket = ticket;
                }

                if (ticket.Price < minPriceTicket.Price)
                {
                    minPriceTicket = ticket;
                }
            }

            Console.WriteLine("Билет с максимальной стоимостью:");
            Console.WriteLine(maxPriceTicket);

            Console.WriteLine("Билет с минимальной стоимостью:");
            Console.WriteLine(minPriceTicket);

            // Список билетов с багажом
            Console.WriteLine("\nСписок билетов с багажом:");
            foreach (Ticket ticket in tickets)
            {
                if (ticket.Luggage)
                {
                    Console.WriteLine(ticket);
                }
            }

            // Список льготных билетов
            Console.WriteLine("\nСписок льготных билетов:");
            foreach (Ticket ticket in tickets)
            {
                if (ticket.Discounted)
                {
                    Console.WriteLine(ticket);
                }
            }
        }
    }
}