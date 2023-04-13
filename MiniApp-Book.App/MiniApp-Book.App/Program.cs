using MiniApp_Book.App.Services.Implementations;

BookService BookServices = new BookService();
Console.WriteLine("0. Close App");
Console.WriteLine("1. Show books");
Console.WriteLine("2. Add book");
Console.WriteLine();
string RequestNumber = Console.ReadLine();
Console.WriteLine();

while(RequestNumber != "0")
{
    switch(RequestNumber)
    {
        case "1":
            BookServices.ShowBooks(); break;

        case "2":
            BookServices.AddBook(); break;

        default:
            Console.WriteLine("Enter a valid option:");
            Console.WriteLine();
            break;
    }

    Console.WriteLine("0. Close App");
    Console.WriteLine("1. Show books");
    Console.WriteLine("2. Add book");
    Console.WriteLine();
    RequestNumber = Console.ReadLine();
    Console.WriteLine();
}