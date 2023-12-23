using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace audioecommerce.Migrations
{
    /// <inheritdoc />
    public partial class DUMMYCART2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3753), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3779), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3785), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4066), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3807), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3812), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3870), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3961), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3964), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4000), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4003), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4006), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4015), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4027), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4030), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4040), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4043), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 47, 10, 247, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 12, 22, 17, 47, 10, 247, DateTimeKind.Local).AddTicks(7712), new DateTime(2023, 12, 22, 17, 47, 10, 247, DateTimeKind.Local).AddTicks(7713), "3B3DD5647D35489EB11FF15030FBF150264953946DB964CB53158B7C4E34645248D890ACAC7E174733CBF41E6BD1D65DA409ABE06A57493977FEBF5FAC52F4C6", new byte[] { 55, 222, 186, 135, 113, 40, 16, 80, 42, 109, 200, 32, 231, 36, 128, 118, 68, 9, 217, 131, 222, 117, 13, 159, 117, 76, 207, 2, 240, 28, 220, 31, 26, 250, 199, 213, 158, 175, 28, 17, 142, 94, 195, 157, 195, 168, 94, 210, 24, 153, 230, 159, 191, 108, 9, 39, 80, 97, 79, 239, 86, 153, 95, 24 } });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "Email", "IsDeleted", "ModifiedDate", "Name", "Password", "Role", "Salt", "Surname" },
                values: new object[] { 100, new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3262), new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3339), "barcaldejan@gmail.com", false, new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3340), "Dejan", "873C77C90EF18A2712C43A10500F3E4C59002160EF0DC4E040EE72A5E0A7F7944EB6CB5344941DBF12735A0CC56203F5AD4F344C805CEDFAEC9F9F1B652922FB", "ADMIN", new byte[] { 177, 34, 84, 205, 2, 190, 202, 20, 69, 91, 38, 172, 68, 213, 34, 232, 81, 182, 141, 78, 124, 157, 56, 3, 120, 127, 90, 27, 110, 21, 114, 13, 88, 85, 136, 247, 164, 169, 196, 251, 232, 254, 151, 253, 201, 112, 73, 220, 58, 82, 64, 73, 219, 220, 114, 161, 112, 43, 232, 187, 33, 120, 185, 43 }, "Barcal" });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Total", "UserId" },
                values: new object[] { 2, new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4072), false, new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4073), 0.0, 100 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);

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
        }
    }
}
