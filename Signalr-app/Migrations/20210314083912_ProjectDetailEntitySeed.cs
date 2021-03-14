using Microsoft.EntityFrameworkCore.Migrations;

namespace SignalRAwsService.Migrations
{
    public partial class ProjectDetailEntitySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO projectdetail (name, authorname) values ('SignalR with RabbitMQ', 'Patrik Duch') ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM projectdetail");
        }
    }
}
