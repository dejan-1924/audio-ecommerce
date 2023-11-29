using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace audioecommerce.Migrations
{
    /// <inheritdoc />
    public partial class ProductImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5687), "https://www.revolvermag.com/sites/default/files/styles/original_image__844px_x_473px_/public/media/section-media/dirt_cover.jpg?itok=p8cv17Bi&timestamp=1506099877", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5696), "https://i.ebayimg.com/images/g/97YAAOSw96JgV8VP/s-l1200.webp", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5700), "https://lostposters.com/wp-content/uploads/2022/12/Album-AliceInChainsSapEP.jpg\r\n", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5703), "https://m.media-amazon.com/images/I/71rt-HQ-uzL._UF1000,1000_QL80_.jpg", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5708), "https://external-preview.redd.it/VWC_u7czD3dOxHqy8JoIpR5453ecP1J5UU6NR6H9fVo.jpg?auto=webp&s=fc23b13ac83473ee1d22794fb16d877ae029755e", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5712), "https://static1.squarespace.com/static/565c1ab5e4b05079e4bfa169/565c268fe4b04e8771155c8c/594622b92994cac22764a55b/1688621277686/Nirvana+Bleach+Album+Cover.jpg?format=1500w", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5715), "https://images.theconversation.com/files/421858/original/file-20210917-31825-dmecrb.jpg?ixlib=rb-1.1.0&rect=36%2C26%2C3458%2C3468&q=45&auto=format&w=926&fit=clip", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5718), "https://impact89fm.org/wp-content/uploads/2023/04/in-utero.jpg", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5722), "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Nirvana_album_cover.svg/1200px-Nirvana_album_cover.svg.png", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5725), "https://media.pitchfork.com/photos/5b3244c8f96f675aaf0b6f69/master/pass/Nirvana%20-%20Incesticide.jpg", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5728), "https://i.discogs.com/4xa_lkoBOHO_GtskzDYK7y-DloQ01VbEhOVfsRyKZWA/rs:fit/g:sm/q:90/h:545/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTU2ODg0/MDktMTM5OTk3NzA0/MC05NDc1LmpwZWc.jpeg", new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "ArtistId", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedDate", "Name", "Price" },
                values: new object[] { 12, 20, 1, new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5693), "Proba", "https://m.media-amazon.com/images/I/81EAuKlg2rS.jpg", false, new DateTime(2023, 11, 29, 18, 36, 48, 40, DateTimeKind.Local).AddTicks(5694), "Facelift", 30.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8893), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8901), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8912), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8916), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8919), new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8920) });
        }
    }
}
