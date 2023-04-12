using Book_MiniApp.Core.Models;

namespace Book_MiniApp.App.Services
{
    internal class BookService
    {
        Book[] Books = new Book[0];
        
        public void ShowBooks()
        {
            if(Books.Length == 0) { Console.WriteLine("No available books..."); }
            foreach (Book Book in Books) { Book.GetFullInfo(); }
            Console.WriteLine();
        }

        public void AddBook()
        {
            Array.Resize(ref Books, Books.Length + 1);

            Console.WriteLine("Enter the title:");
            string Title = Console.ReadLine();
            while(String.IsNullOrWhiteSpace(Title)  || Title.Length == 0)
            {
                Console.WriteLine("Enter the title again:"); 
                Title = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Enter the author:");
             string Author = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(Author) || Author.Length == 0)
            {
                Console.WriteLine("Enter the author again:");
                Author = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Enter the price");
            string StringPrice = Console.ReadLine();
            double Price = 0;
            while(Price == 0)
            {
                try
                { Price = double.Parse(StringPrice); }
                catch
                {
                    Console.WriteLine("Enter the price again:");
                    StringPrice = Console.ReadLine();
                }
            }
            Book NewBook = new Book(Title, Author, Price);
            Books[Books.Length - 1] = NewBook;
            Console.WriteLine();
        }
    }
}
