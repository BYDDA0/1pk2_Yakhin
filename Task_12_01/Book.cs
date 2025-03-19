using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private bool isIssued;

        public void GetInfo()
        {
            Console.WriteLine($"{Author} : {Title}");
        }

        public void GetBook()
        {
            if (!isIssued)
            {
                isIssued = true;
                Console.WriteLine($"Книга '{Title}' выдана на неделю.");
            }
            else
            {
                Console.WriteLine($"Книга '{Title}' в данный момент выдана другому читателю.");
            }
        }

        public void ReturnBook()
        {
            if (isIssued)
            {
                isIssued = false;
                Console.WriteLine($"Книга '{Title}' возвращена и теперь доступна.");
            }
            else
            {
                Console.WriteLine($"Книга '{Title}' уже доступна.");
            }
        }
    }
}
