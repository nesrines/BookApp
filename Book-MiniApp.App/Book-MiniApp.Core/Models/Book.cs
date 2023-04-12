namespace Book_MiniApp.Core.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book(string Title, string Author, double Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }

        public void GetFullInfo()
        { Console.WriteLine(Title + " by " + Author + " - $" + Price); }
    }
}
