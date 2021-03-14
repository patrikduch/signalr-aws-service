using Microsoft.EntityFrameworkCore.Migrations;

namespace SignalRAwsService.Migrations
{
    public partial class ProjectDetailAuthorNameAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "authorname",
                table: "projectdetail",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "authorname",
                table: "projectdetail");
        }
    }
}
