using Book_MiniApp.App.Services;

Console.WriteLine("0 - Close app");
Console.WriteLine("1 - Show books");
Console.WriteLine("2 - Add a new book");
Console.WriteLine();
string RequestNumber = Console.ReadLine();
Console.WriteLine();

BookService BookService = new BookService();

while(RequestNumber != "0")
{
    switch(RequestNumber)
    {
        case "1":
            BookService.ShowBooks();
            break;

        case "2":
            BookService.AddBook();
            break;

        default:
            Console.WriteLine("Enter a valid option");
            Console.WriteLine();
            break;
    }
    Console.WriteLine("0 - Close app");
    Console.WriteLine("1 - Show books");
    Console.WriteLine("2 - Add a new book");
    Console.WriteLine();
    RequestNumber = Console.ReadLine();
    Console.WriteLine();
}