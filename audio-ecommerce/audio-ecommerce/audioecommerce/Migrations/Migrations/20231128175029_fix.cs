using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace audioecommerce.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "ArtistId", "CreatedDate", "Description", "IsDeleted", "ModifiedDate", "Name", "Price" },
                values: new object[] { 1, 20, 1, new DateTime(2023, 11, 28, 18, 50, 29, 831, DateTimeKind.Local).AddTicks(8460), "Proba", false, new DateTime(2023, 11, 28, 18, 50, 29, 831, DateTimeKind.Local).AddTicks(8462), "Dirt ", 30.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "Products",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 28, 17, 2, 38, 988, DateTimeKind.Local).AddTicks(4189), new DateTime(2023, 11, 28, 17, 2, 38, 988, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 28, 17, 2, 38, 988, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 11, 28, 17, 2, 38, 988, DateTimeKind.Local).AddTicks(4289) });
        }
    }
}
