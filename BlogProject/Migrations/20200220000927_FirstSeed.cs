using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class FirstSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PublishDate = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Author", "Category", "Content", "PublishDate", "Tags", "Title" },
                values: new object[] { 1, "Tom Shaw", "Computers", "Machine learning for humans", "19FEB20", "Machine Learning", "First Blog" });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Author", "Category", "Content", "PublishDate", "Tags", "Title" },
                values: new object[] { 2, "Samuel Burns", "Travel", "The one stop shop for all your traveling needs", "01JAN19", "Cleveland", "Travel for Dummies" });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Author", "Category", "Content", "PublishDate", "Tags", "Title" },
                values: new object[] { 3, "John Doe", "Food", "Tasty Snacks with a low price point", "16MAY17", "Toronto", "Cooking on a Budget" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");
        }
    }
}
