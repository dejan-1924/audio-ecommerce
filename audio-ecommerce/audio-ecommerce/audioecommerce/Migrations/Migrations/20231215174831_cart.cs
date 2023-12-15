using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace audioecommerce.Migrations
{
    /// <inheritdoc />
    public partial class cart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "CartItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8989), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9217), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9016), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9026), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9073), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9078), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9100), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9114), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9118), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9122), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9134), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9176), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9189), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9193), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9198), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8518), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8607), new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8608), "FB3FFAF8C8141C36770E2BA30C12DAF9FCB0482096F0B6627311A688437BFE0DA19ED5487EE6B6D64E007F1F6DB879F137050350EB8D6B477C6A73BD145481CA", new byte[] { 91, 166, 3, 168, 46, 48, 39, 215, 41, 237, 71, 226, 196, 162, 40, 97, 89, 244, 110, 129, 100, 92, 158, 40, 42, 29, 53, 154, 177, 34, 136, 117, 45, 101, 236, 68, 21, 147, 195, 105, 198, 194, 247, 200, 145, 226, 157, 57, 199, 197, 183, 195, 22, 107, 45, 132, 221, 66, 128, 137, 195, 153, 179, 209 } });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "CartItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6064), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6134), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6176), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6275), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6295), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6301), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6393), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6400), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6407), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6415), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6426), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(5004), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(5177), "B621B226F00C367E85E5B66DFA60DB95E194F9F185C1825845D5213BD1D15CE07406D0922CC37D4574368229AD7B0765B5CA343294BCA56F277EADF4E9CC1A91", new byte[] { 208, 47, 217, 189, 89, 40, 247, 119, 201, 79, 160, 14, 15, 29, 204, 157, 144, 172, 208, 99, 181, 21, 182, 54, 197, 66, 190, 221, 240, 134, 91, 43, 183, 151, 144, 246, 101, 157, 217, 32, 69, 185, 120, 78, 205, 28, 230, 172, 122, 84, 10, 32, 201, 163, 52, 232, 203, 147, 56, 17, 96, 177, 4, 200 } });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id");
        }
    }
}
