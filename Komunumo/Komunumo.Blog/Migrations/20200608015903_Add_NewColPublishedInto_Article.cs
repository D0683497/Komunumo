using Microsoft.EntityFrameworkCore.Migrations;

namespace Komunumo.Blog.Migrations
{
    public partial class Add_NewColPublishedInto_Article : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Article",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Published",
                table: "Article");
        }
    }
}
