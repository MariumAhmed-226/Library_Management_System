using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(4192), new DateTime(2025, 4, 22, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 4, 12, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5962), new DateTime(2025, 4, 17, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 4, 7, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5967), new DateTime(2025, 4, 12, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 4, 2, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5969), new DateTime(2025, 4, 7, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5971), new DateTime(2025, 4, 2, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 3, 23, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5973), new DateTime(2025, 3, 28, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 3, 18, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5975), new DateTime(2025, 3, 23, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 3, 13, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5977), new DateTime(2025, 3, 18, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 3, 8, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5978), new DateTime(2025, 3, 13, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "BorrowRecords",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 3, 3, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5980), new DateTime(2025, 3, 8, 13, 22, 39, 706, DateTimeKind.Utc).AddTicks(5981) });
        }
    }
}
