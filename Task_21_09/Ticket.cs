using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    internal class Ticket
    {
        public int TicketNumber { get; set; } // Номер билета
        public decimal Price { get; set; } // Цена
        public bool Luggage { get; set; } // Багаж
        public bool Discounted { get; set; } // Льготный билет

        public Ticket(int ticketNumber, decimal price, bool hasLuggage, bool isDiscounted)
        {
            TicketNumber = ticketNumber;
            Price = price;
            Luggage = hasLuggage;
            Discounted = isDiscounted;
        }

        public override string ToString()
        {
            return $"Билет #{TicketNumber}: Цена - {Price}, Багаж - {Luggage}, Льготный - {Discounted}";
        }
    }
}
