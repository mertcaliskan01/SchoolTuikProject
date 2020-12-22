using Microsoft.EntityFrameworkCore.Migrations;

namespace TuikProject.Data.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Column19",
                table: "IssizlikOraniTablo2");

            migrationBuilder.DropColumn(
                name: "Column20",
                table: "IssizlikOraniTablo2");

            migrationBuilder.DropColumn(
                name: "Column21",
                table: "IssizlikOraniTablo2");

            migrationBuilder.DropColumn(
                name: "Column22",
                table: "IssizlikOraniTablo2");

            migrationBuilder.DropColumn(
                name: "Column23",
                table: "IssizlikOraniTablo2");

            migrationBuilder.DropColumn(
                name: "Column24",
                table: "IssizlikOraniTablo2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Column19",
                table: "IssizlikOraniTablo2",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column20",
                table: "IssizlikOraniTablo2",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column21",
                table: "IssizlikOraniTablo2",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column22",
                table: "IssizlikOraniTablo2",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column23",
                table: "IssizlikOraniTablo2",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column24",
                table: "IssizlikOraniTablo2",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
