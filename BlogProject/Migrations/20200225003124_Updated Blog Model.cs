using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class UpdatedBlogModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Blog");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blog",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                table: "Blog",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Blog",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Blog",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Blog",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Blog",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "BlogId");

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "Author", "Category", "Content", "PublishDate", "Tags", "Title" },
                values: new object[] { 1, "Tom Shaw", "Computers", "Machine learning for humans", "19FEB20", "Machine Learning", "First Blog" });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "Author", "Category", "Content", "PublishDate", "Tags", "Title" },
                values: new object[] { 2, "Samuel Burns", "Travel", "The one stop shop for all your traveling needs", "01JAN19", "Cleveland", "Travel for Dummies" });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "Author", "Category", "Content", "PublishDate", "Tags", "Title" },
                values: new object[] { 3, "John Doe", "Food", "Tasty Snacks with a low price point", "16MAY17", "Toronto", "Cooking on a Budget" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Blog");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "Id");

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
    }
}
