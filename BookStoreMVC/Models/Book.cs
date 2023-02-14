namespace BookStoreMVC.Models
{
    public class Book
    {
        public string BookId { get; set; }

        public string BookName { get; set; }

        public bool IsAvailable { get; set; } = true;
    }
}
