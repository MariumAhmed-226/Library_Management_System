namespace Library_Management_System.Models
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string BorrowerName { get; set; } = string.Empty; // Default value
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; } // Nullable

        // Navigation property
        public virtual Book? Book { get; set; } // Nullable
    }
}