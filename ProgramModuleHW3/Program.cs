using ProgramModuleHW3;

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляров книг
        LibraryBook book1 = new LibraryBook("1984", "Трумен Капоте");
        LibraryBook book2 = new LibraryBook("Грозовой перевал", "Эмили Бронте");

        // Демонстрация работы
        book1.DisplayStatus();
        book1.CheckOutBook();
        book1.DisplayStatus();
        book1.CheckOutBook();
        book1.ReturnBook();
        book1.ReturnBook();

        Console.WriteLine();

        book2.DisplayStatus();
        book2.CheckOutBook();
        book2.ReturnBook();
        book2.DisplayStatus();
    }
}
