using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[,]
                {
                    { 1, "A passionate writer from Lahore.", "Ayesha Khan" },
                    { 2, "A poet from Karachi.", "Shaayan" },
                    { 3, "A novelist from Islamabad.", "Zainab Ahmed" },
                    { 4, "A historian from Multan.", "Hira Malik" },
                    { 5, "A storyteller from Faisalabad.", "Sana Sheikh" },
                    { 6, "A biographer from Rawalpindi.", "Mariam Javed" },
                    { 7, "A travel writer from Peshawar.", "Aqsa Riaz" },
                    { 8, "A children's book author from Quetta.", "Nimra Shah" },
                    { 9, "A science fiction writer from Sialkot.", "Iqra Yousaf" },
                    { 10, "A journalist from Hyderabad.", "Rabia Noor" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Bookid", "Authorid", "Genre", "Publishedyear", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Fiction", 2015, "The Journey" },
                    { 2, 2, "Romance", 2018, "Whispers of the Heart" },
                    { 3, 3, "History", 2020, "Echoes of the Past" },
                    { 4, 4, "Mystery", 2017, "The Forgotten Tale" },
                    { 5, 5, "Science Fiction", 2019, "Dreams of Tomorrow" },
                    { 6, 6, "Thriller", 2021, "The Silent Witness" },
                    { 7, 7, "Adventure", 2016, "Winds of Change" },
                    { 8, 8, "Fantasy", 2014, "The Golden Horizon" },
                    { 9, 9, "Psychology", 2022, "Shadows of the Mind" },
                    { 10, 10, "Drama", 2023, "The Final Chapter" }
                });

            migrationBuilder.InsertData(
                table: "BorrowRecords",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowerName", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 17, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(4192), "Ayesha Khan", new DateTime(2025, 4, 22, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(4759) },
                    { 2, 2, new DateTime(2025, 4, 12, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5962), "Fatima Ali", new DateTime(2025, 4, 17, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5964) },
                    { 3, 3, new DateTime(2025, 4, 7, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5967), "Zainab Ahmed", new DateTime(2025, 4, 12, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5967) },
                    { 4, 4, new DateTime(2025, 4, 2, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5969), "Hira Malik", new DateTime(2025, 4, 7, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5969) },
                    { 5, 5, new DateTime(2025, 3, 28, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5971), "Sana Sheikh", new DateTime(2025, 4, 2, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5971) },
                    { 6, 6, new DateTime(2025, 3, 23, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5973), "Mariam Javed", new DateTime(2025, 3, 28, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5973) },
                    { 7, 7, new DateTime(2025, 3, 18, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5975), "Aqsa Riaz", new DateTime(2025, 3, 23, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5975) },
                    { 8, 8, new DateTime(2025, 3, 13, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5977), "Nimra Shah", new DateTime(2025, 3, 18, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5977) },
                    { 9, 9, new DateTime(2025, 3, 8, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5978), "Iqra Yousaf", new DateTime(2025, 3, 13, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5979) },
                    { 10, 10, new DateTime(2025, 3, 3, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5980), "Rabia Noor", new DateTime(2025, 3, 8, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5981) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Bookid",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
