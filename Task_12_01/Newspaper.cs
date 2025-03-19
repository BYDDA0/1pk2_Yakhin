using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    public class Newspaper
    {
        public DateTime PublicationDate { get; set; }
        public string Title { get; set; }
        public string Headline { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }

        public void Purchase()
        {
            Console.WriteLine($"Вы купили газету '{Title}' за {Price} рублей.");
        }

        public void ViewContent()
        {
            Console.WriteLine($"Заголовок: '{Headline}'\nКоличество страниц: {Pages}");
        }
    }
}
