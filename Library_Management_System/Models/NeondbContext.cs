using Library_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Authors
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Ayesha Khan", Bio = "A passionate writer from Lahore." },
                new Author { Id = 2, Name = "Shaayan", Bio = "A poet from Karachi." },
                new Author { Id = 3, Name = "Zainab Ahmed", Bio = "A novelist from Islamabad." },
                new Author { Id = 4, Name = "Hira Malik", Bio = "A historian from Multan." },
                new Author { Id = 5, Name = "Sana Sheikh", Bio = "A storyteller from Faisalabad." },
                new Author { Id = 6, Name = "Mariam Javed", Bio = "A biographer from Rawalpindi." },
                new Author { Id = 7, Name = "Aqsa Riaz", Bio = "A travel writer from Peshawar." },
                new Author { Id = 8, Name = "Nimra Shah", Bio = "A children's book author from Quetta." },
                new Author { Id = 9, Name = "Iqra Yousaf", Bio = "A science fiction writer from Sialkot." },
                new Author { Id = 10, Name = "Rabia Noor", Bio = "A journalist from Hyderabad." }
            );

            // Seed Books
            modelBuilder.Entity<Book>().HasData(
                new Book { Bookid = 1, Title = "The Journey", Genre = "Fiction", Authorid = 1, Publishedyear = 2015 },
                new Book { Bookid = 2, Title = "Whispers of the Heart", Genre = "Romance", Authorid = 2, Publishedyear = 2018 },
                new Book { Bookid = 3, Title = "Echoes of the Past", Genre = "History", Authorid = 3, Publishedyear = 2020 },
                new Book { Bookid = 4, Title = "The Forgotten Tale", Genre = "Mystery", Authorid = 4, Publishedyear = 2017 },
                new Book { Bookid = 5, Title = "Dreams of Tomorrow", Genre = "Science Fiction", Authorid = 5, Publishedyear = 2019 },
                new Book { Bookid = 6, Title = "The Silent Witness", Genre = "Thriller", Authorid = 6, Publishedyear = 2021 },
                new Book { Bookid = 7, Title = "Winds of Change", Genre = "Adventure", Authorid = 7, Publishedyear = 2016 },
                new Book { Bookid = 8, Title = "The Golden Horizon", Genre = "Fantasy", Authorid = 8, Publishedyear = 2014 },
                new Book { Bookid = 9, Title = "Shadows of the Mind", Genre = "Psychology", Authorid = 9, Publishedyear = 2022 },
                new Book { Bookid = 10, Title = "The Final Chapter", Genre = "Drama", Authorid = 10, Publishedyear = 2023 }
            );

            // Seed BorrowRecords with static DateTime values
            modelBuilder.Entity<BorrowRecord>().HasData(
                new BorrowRecord { Id = 1, BookId = 1, BorrowerName = "Ayesha Khan", BorrowDate = new DateTime(2023, 4, 1), ReturnDate = new DateTime(2023, 4, 6) },
                new BorrowRecord { Id = 2, BookId = 2, BorrowerName = "Fatima Ali", BorrowDate = new DateTime(2023, 3, 25), ReturnDate = new DateTime(2023, 3, 30) },
                new BorrowRecord { Id = 3, BookId = 3, BorrowerName = "Zainab Ahmed", BorrowDate = new DateTime(2023, 3, 20), ReturnDate = new DateTime(2023, 3, 25) },
                new BorrowRecord { Id = 4, BookId = 4, BorrowerName = "Hira Malik", BorrowDate = new DateTime(2023, 3, 15), ReturnDate = new DateTime(2023, 3, 20) },
                new BorrowRecord { Id = 5, BookId = 5, BorrowerName = "Sana Sheikh", BorrowDate = new DateTime(2023, 3, 10), ReturnDate = new DateTime(2023, 3, 15) },
                new BorrowRecord { Id = 6, BookId = 6, BorrowerName = "Mariam Javed", BorrowDate = new DateTime(2023, 3, 5), ReturnDate = new DateTime(2023, 3, 10) },
                new BorrowRecord { Id = 7, BookId = 7, BorrowerName = "Aqsa Riaz", BorrowDate = new DateTime(2023, 3, 1), ReturnDate = new DateTime(2023, 3, 6) },
                new BorrowRecord { Id = 8, BookId = 8, BorrowerName = "Nimra Shah", BorrowDate = new DateTime(2023, 2, 25), ReturnDate = new DateTime(2023, 3, 2) },
                new BorrowRecord { Id = 9, BookId = 9, BorrowerName = "Iqra Yousaf", BorrowDate = new DateTime(2023, 2, 20), ReturnDate = new DateTime(2023, 2, 25) },
                new BorrowRecord { Id = 10, BookId = 10, BorrowerName = "Rabia Noor", BorrowDate = new DateTime(2023, 2, 15), ReturnDate = new DateTime(2023, 2, 20) }
            );
        }
    }
}
