using MiniApp_Book.Core.Models.BaseModels;

namespace MiniApp_Book.Core.Models
{
    public class Book : BaseModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
