using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class AddedDisplayTypeToBlogModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 2, 25, 8, 34, 15, 315, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 2, 25, 8, 34, 15, 317, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 2, 25, 8, 34, 15, 317, DateTimeKind.Local).AddTicks(6217));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 2, 24, 19, 40, 8, 43, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 2, 24, 19, 40, 8, 46, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 2, 24, 19, 40, 8, 46, DateTimeKind.Local).AddTicks(4445));
        }
    }
}
