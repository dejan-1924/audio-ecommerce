using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace audioecommerce.Migrations
{
    /// <inheritdoc />
    public partial class LabelsAndFormats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormatId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Format",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Format", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Format",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9053), false, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9054), "Vinyl" },
                    { 2, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9058), false, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9059), "CD" }
                });

            migrationBuilder.InsertData(
                table: "Label",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9076), false, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9078), "Sony" },
                    { 2, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9081), false, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9082), "Music On Vinyl" },
                    { 3, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9084), false, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9085), "Roadrunner Records" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9102), 1, 1, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9114), 1, 2, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9118), 1, 1, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9121), 1, 2, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9126), 1, 1, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9130), 1, 3, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9134), 1, 3, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9137), 1, 3, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9141), 1, 1, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9145), 1, 2, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9148), 1, 2, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "FormatId", "LabelId", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9111), 1, 1, new DateTime(2023, 12, 1, 12, 3, 44, 566, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_FormatId",
                table: "Products",
                column: "FormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LabelId",
                table: "Products",
                column: "LabelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Format_FormatId",
                table: "Products",
                column: "FormatId",
                principalTable: "Format",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Label_LabelId",
                table: "Products",
                column: "LabelId",
                principalTable: "Label",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Format_FormatId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Label_LabelId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Format");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropIndex(
                name: "IX_Products_FormatId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_LabelId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FormatId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5665), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5687), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5696), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5693), new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5694) });
        }
    }
}
