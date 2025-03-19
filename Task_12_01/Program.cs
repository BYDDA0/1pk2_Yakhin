namespace Task_12_01
{
    internal class Program
    { /* клонировать и разобрать. добавить в класс Book метод 
       * с помощью которого пользователь возвращает книгу и ее статус снова переводится в «свободен» 
       * в этом же проекте реализуйте класс Journal (журнал) со следующими данными: 
       * дата издания, предметно-тематическая направленность журнала, название, количество страниц, ценафункционал класса: 
       * покупка журнала 
       * просмотр содержания журнала 
       * в этом же проекте реализуйте класс Newspaper (газета) со следующими данными: 
       * дата издания, название газеты, заголовок главной полосы, количество страниц, цена 
       * функционал класса:*/
        static void Main(string[] args)
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { Title = "Автостопом по галактике", Author = "Дуглас Адамс" };
            Book book4 = new Book() { Title = "Хоббит", Author = "Джон Толкин" };

            book1.Author = "Рей Бредберри";
            book1.Title = "Марсианские хроники";
            book1.GetInfo();

            book2.Author = "Джона Роулинг";
            book2.Title = "Гарри Поттер и философский камень";
            book2.GetInfo();

            // Выдача книги
            book2.GetBook();

            // Попытка выдать уже занятую книгу
            book2.GetBook();

            // Возврат книги
            book2.ReturnBook();
            book2.ReturnBook(); // Повторное возвращение

            // Пример использования класса Journal
            Journal journal = new Journal()
            {
                PublicationDate = DateTime.Today,
                Subject = "Наука и техника",
                Title = "Научный Мир",
                Pages = 49,
                Price = 150.00m
            };
            journal.Purchase();
            journal.ViewContent();

            // Пример использования класса Newspaper
            Newspaper newspaper = new Newspaper()
            {
                PublicationDate = DateTime.Today,
                Title = "Новости дня",
                Headline = "Сегодня день перемен",
                Pages = 23,
                Price = 50.00m
            };
            newspaper.Purchase();
            newspaper.ViewContent();
        }
    }
}
