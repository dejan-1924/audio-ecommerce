using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace audioecommerce.Migrations
{
    /// <inheritdoc />
    public partial class CartMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductId",
                table: "CartItem",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(710), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(712) });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(328), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 12, 6, 15, 42, 56, 759, DateTimeKind.Local).AddTicks(388), "D5F7F4761B104B96EAB9CEC1925C743F417140B49956CB0853EC9B3FBE877A6E6F2A0606F142BA20099D8FC385E0DB683977A5C5BBA8B7D5D0A8E0CFE3B7CA7F", new byte[] { 161, 99, 237, 201, 91, 227, 27, 1, 169, 185, 52, 245, 12, 81, 68, 120, 166, 152, 195, 57, 161, 42, 227, 113, 50, 198, 28, 211, 143, 134, 67, 147, 201, 11, 49, 97, 201, 63, 87, 104, 155, 72, 5, 30, 53, 98, 219, 168, 207, 141, 1, 83, 242, 179, 174, 154, 21, 140, 221, 75, 163, 75, 11, 69 } });
        }
    }
}
