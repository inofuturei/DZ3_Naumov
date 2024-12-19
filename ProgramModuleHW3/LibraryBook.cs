namespace ProgramModuleHW3
{
    class LibraryBook
    {
        // Закрытые поля
        private string title;
        private string author;
        private bool isCheckedOut;

        // Конструктор
        public LibraryBook(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.isCheckedOut = false;
        }

        // Публичные свойства только для чтения
        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        // Методы
        public void CheckOutBook()
        {
            if (isCheckedOut)
            {
                Console.WriteLine($"Книга \"{title}\" уже взята.");
            }
            else
            {
                isCheckedOut = true;
                Console.WriteLine($"Вы успешно взяли книгу \"{title}\".");
            }
        }

        public void ReturnBook()
        {
            if (!isCheckedOut)
            {
                Console.WriteLine($"Книга \"{title}\" уже доступна.");
            }
            else
            {
                isCheckedOut = false;
                Console.WriteLine($"Вы успешно вернули книгу \"{title}\".");
            }
        }

        public void DisplayStatus()
        {
            string status = isCheckedOut ? "взята" : "доступна";
            Console.WriteLine($"Книга: \"{title}\", Автор: {author}, Статус: {status}");
        }
    }
}
