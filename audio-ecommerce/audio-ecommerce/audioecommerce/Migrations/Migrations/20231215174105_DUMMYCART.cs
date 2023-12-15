using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace audioecommerce.Migrations
{
    /// <inheritdoc />
    public partial class DUMMYCART : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Total", "UserId" },
                values: new object[] { 1, new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6463), false, new DateTime(2023, 12, 15, 18, 41, 5, 300, DateTimeKind.Local).AddTicks(6465), 0.0, 1 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9355), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9373), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9402), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9410), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9435), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9461), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9465), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9484), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9494), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9498), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9502), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9513), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9548), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9552), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9561), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9564), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9568), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9490), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9003), new DateTime(2023, 12, 15, 18, 13, 30, 717, DateTimeKind.Local).AddTicks(9005), "7157D6432ED5CE30E0257E01355D12D0138E83765D8D6D7B1F3A5CE7DD377417C1E4987442E46FF5C82E165AEDE6D8DDD4DD1A903579D85125A7B40C400B539E", new byte[] { 111, 223, 134, 96, 160, 211, 64, 39, 79, 211, 87, 159, 171, 67, 98, 236, 128, 175, 126, 84, 130, 167, 132, 46, 84, 223, 34, 0, 159, 167, 154, 44, 153, 178, 46, 196, 179, 173, 90, 247, 206, 70, 159, 66, 216, 180, 65, 107, 182, 2, 215, 61, 62, 110, 215, 7, 67, 61, 29, 154, 237, 156, 173, 241 } });
        }
    }
}
