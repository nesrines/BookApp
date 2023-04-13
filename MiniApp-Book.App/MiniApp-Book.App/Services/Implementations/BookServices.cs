using MiniApp_Book.App.Services.Interfaces;
using MiniApp_Book.Core.Models;

namespace MiniApp_Book.App.Services.Implementations
{
    internal class BookService:IBookServices
    {
        private Book[] Books = { };
        public void ShowBooks()
        {
            if (Books.Length == 0) { Console.WriteLine("There are no available books. Please, add a book"); }
            else
            {
                foreach (Book Book in Books)
                { Console.WriteLine($"{Book.Title} by {Book.Author} - ${Book.Price}"); }
            }
            Console.WriteLine();
        }
        public void AddBook()
        {
            Array.Resize(ref Books, Books.Length + 1);
            Book NewBook = new Book();

            Console.WriteLine("Enter the title:");
            NewBook.Title = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(NewBook.Title) || NewBook.Title.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Title can't be empty. Enter the title again:");
                NewBook.Title = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Enter the author:");
            NewBook.Author = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(NewBook.Author) || NewBook.Author.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Author can't be empty. Enter the author again:");
                NewBook.Author = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Enter the price");
            string StringPrice = Console.ReadLine();
            while (NewBook.Price == 0)
            {
                try { NewBook.Price = double.Parse(StringPrice); }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Price is not in the correct format. Enter the price again:");
                    StringPrice = Console.ReadLine();
                }
            }
          
            Books[Books.Length - 1] = NewBook;
            Console.WriteLine();
        }
    }
}
