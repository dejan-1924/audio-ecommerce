using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace audioecommerce.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8880), "Dirt" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "ArtistId", "CreatedDate", "Description", "IsDeleted", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 2, 15, 1, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8886), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8887), "Jar Of Flies", 35.0 },
                    { 3, 20, 1, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8889), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8890), "Sap", 20.0 },
                    { 4, 10, 1, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8893), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8894), "MTV Unplugged", 40.0 },
                    { 5, 20, 1, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8896), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8897), "Alice In Chains", 50.0 },
                    { 6, 20, 2, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8901), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8903), "Bleach", 20.0 },
                    { 7, 20, 2, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8905), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8906), "Nevermind", 30.0 },
                    { 8, 10, 2, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8909), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8910), "In Utero", 45.0 },
                    { 9, 20, 2, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8912), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8913), "Nirvana", 15.0 },
                    { 10, 20, 2, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8916), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8917), "Incesticide", 20.0 },
                    { 11, 20, 2, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8919), "Proba", false, new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8920), "MTV Unplugged In New York", 45.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 28, 18, 50, 29, 831, DateTimeKind.Local).AddTicks(8372), new DateTime(2023, 11, 28, 18, 50, 29, 831, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 28, 18, 50, 29, 831, DateTimeKind.Local).AddTicks(8439), new DateTime(2023, 11, 28, 18, 50, 29, 831, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2023, 11, 28, 18, 50, 29, 831, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 11, 28, 18, 50, 29, 831, DateTimeKind.Local).AddTicks(8462), "Dirt " });
        }
    }
}
