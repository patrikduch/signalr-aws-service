using Microsoft.EntityFrameworkCore.Migrations;

namespace SignalRAwsService.Migrations
{
    public partial class ProjectDetailNameAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "projectdetail",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "projectdetail");
        }
    }
}
