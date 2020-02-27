using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class UpdateBlogRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Blog");

            migrationBuilder.AddColumn<int>(
                name: "TagId1",
                table: "Tag",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Blog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Blog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Technology" },
                    { 2, "Travel" },
                    { 3, "Cooking" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "TagId", "TagId1", "TagName" },
                values: new object[,]
                {
                    { 1, null, "Toronto" },
                    { 2, null, "Celveland" },
                    { 3, null, "Pittsburgh" }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 1, new DateTime(2020, 2, 26, 21, 41, 18, 791, DateTimeKind.Local).AddTicks(8667), 1 });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 2, new DateTime(2020, 2, 26, 21, 41, 18, 794, DateTimeKind.Local).AddTicks(2951), 2 });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 3, new DateTime(2020, 2, 26, 21, 41, 18, 794, DateTimeKind.Local).AddTicks(2999), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Tag_TagId1",
                table: "Tag",
                column: "TagId1");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CategoryId",
                table: "Blog",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_TagId",
                table: "Blog",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Category_CategoryId",
                table: "Blog",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Tag_TagId",
                table: "Blog",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Tag_TagId1",
                table: "Tag",
                column: "TagId1",
                principalTable: "Tag",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Category_CategoryId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Tag_TagId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Tag_TagId1",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_TagId1",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Blog_CategoryId",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_TagId",
                table: "Blog");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "TagId1",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Blog");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                columns: new[] { "Category", "PublishDate", "Tags" },
                values: new object[] { "Computers", new DateTime(2020, 2, 25, 8, 34, 15, 315, DateTimeKind.Local).AddTicks(2637), "Machine Learning" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                columns: new[] { "Category", "PublishDate", "Tags" },
                values: new object[] { "Travel", new DateTime(2020, 2, 25, 8, 34, 15, 317, DateTimeKind.Local).AddTicks(6156), "Cleveland" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                columns: new[] { "Category", "PublishDate", "Tags" },
                values: new object[] { "Food", new DateTime(2020, 2, 25, 8, 34, 15, 317, DateTimeKind.Local).AddTicks(6217), "Toronto" });
        }
    }
}
