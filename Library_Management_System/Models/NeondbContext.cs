using Library_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_Management_System.Data
{
    public class NeondbContext : DbContext
    {
        public NeondbContext(DbContextOptions<NeondbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }
    }
}
