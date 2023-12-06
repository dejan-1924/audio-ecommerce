using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace audioecommerce.Migrations
{
    /// <inheritdoc />
    public partial class USERMIGRATION : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Addresses",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(733), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(754), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(781), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(789), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(815), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(839), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(844), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(961), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(973), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(991), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1009), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1052), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1057), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1061), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(969), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "Email", "IsDeleted", "ModifiedDate", "Name", "Password", "Role", "Salt", "Surname" },
                values: new object[] { 1, new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(328), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(387), "admin@gmail.com", false, new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(388), "Admin", "D5F7F4761B104B96EAB9CEC1925C743F417140B49956CB0853EC9B3FBE877A6E6F2A0606F142BA20099D8FC385E0DB683977A5C5BBA8B7D5D0A8E0CFE3B7CA7F", "ADMIN", new byte[] { 161, 99, 237, 201, 91, 227, 27, 1, 169, 185, 52, 245, 12, 81, 68, 120, 166, 152, 195, 57, 161, 42, 227, 113, 50, 198, 28, 211, 143, 134, 67, 147, 201, 11, 49, 97, 201, 63, 87, 104, 155, 72, 5, 30, 53, 98, 219, 168, 207, 141, 1, 83, 242, 179, 174, 154, 21, 140, 221, 75, 163, 75, 11, 69 }, "Admin" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "IsBilling", "IsDeleted", "IsShipping", "ModifiedDate", "PhoneNumber", "Street", "UserId", "ZipCode" },
                values: new object[] { 1, "Novi Sad", "Serbia", new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(710), true, false, true, new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(712), "+387625463456", "Petra Petrovica 1", 1, "21000" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(8968), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9031), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9053), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Format",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9058), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9076), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9081), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "Label",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9084), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9102), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9114), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9118), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9121), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9126), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9130), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9134), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9137), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9141), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9145), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9148), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9111), new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9112) });
        }
    }
}
