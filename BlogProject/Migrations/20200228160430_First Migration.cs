using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blog_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blog_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "Toronto" },
                    { 2, "Cleveland" },
                    { 3, "Pittsburgh" }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "Author", "CategoryId", "Content", "PublishDate", "TagId", "Title" },
                values: new object[] { 1, "Tom Shaw", 1, "Machine learning for humans", new DateTime(2020, 2, 28, 11, 4, 30, 174, DateTimeKind.Local).AddTicks(4714), 1, "First Blog" });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "Author", "CategoryId", "Content", "PublishDate", "TagId", "Title" },
                values: new object[] { 2, "Samuel Burns", 2, "The one stop shop for all your traveling needs", new DateTime(2020, 2, 28, 11, 4, 30, 176, DateTimeKind.Local).AddTicks(6916), 2, "Travel for Dummies" });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "Author", "CategoryId", "Content", "PublishDate", "TagId", "Title" },
                values: new object[] { 3, "John Doe", 3, "Tasty Snacks with a low price point", new DateTime(2020, 2, 28, 11, 4, 30, 176, DateTimeKind.Local).AddTicks(6958), 3, "Cooking on a Budget" });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CategoryId",
                table: "Blog",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_TagId",
                table: "Blog",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Tag");
        }
    }
}
