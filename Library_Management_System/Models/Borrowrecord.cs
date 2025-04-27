namespace Library_Management_System.Models
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string BorrowerName { get; set; } = string.Empty; // Default value
        private DateTime _borrowDate;

        public DateTime BorrowDate
        {
            get => _borrowDate;
            set => _borrowDate = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        private DateTime? _returnDate;

        public DateTime? ReturnDate
        {
            get => _returnDate;
            set => _returnDate = value.HasValue ? DateTime.SpecifyKind(value.Value, DateTimeKind.Utc) : null;
        }

        // Navigation property
        public virtual Book? Book { get; set; } // Nullable
    }
}