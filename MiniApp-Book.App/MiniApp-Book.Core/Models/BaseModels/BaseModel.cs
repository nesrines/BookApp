namespace MiniApp_Book.Core.Models.BaseModels
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime DateWasAdded { get; set; }
    }
}
