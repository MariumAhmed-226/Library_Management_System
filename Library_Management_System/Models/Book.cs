using System.Collections.Generic;

namespace Library_Management_System.Models
{
    public class Book
    {
        public int Bookid { get; set; } // Primary key
        public string Title { get; set; } = string.Empty; // Non-nullable with default value
        public string? Genre { get; set; } // Nullable
        public int? Authorid { get; set; } // Nullable foreign key
        public int? Publishedyear { get; set; } // Nullable

        // Navigation property
        public virtual Author? Author { get; set; }
        public virtual ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
    }
}
