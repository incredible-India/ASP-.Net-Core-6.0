using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDefaultController.Migrations
{
    public partial class addage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "studentsTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "studentsTable");
        }
    }
}
