using Microsoft.EntityFrameworkCore.Migrations;

namespace TuikProject.Data.Migrations
{
    public partial class migrationFourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column1",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column10",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column11",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column12",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column13",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column14",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column15",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column16",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column17",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column18",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column2",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column3",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column4",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column5",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column6",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column7",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column8",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "Column9",
                table: "IssizlikOrani");

            migrationBuilder.DropColumn(
                name: "TableName",
                table: "IssizlikOrani");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column1",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column10",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column11",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column12",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column13",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column14",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column15",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column16",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column17",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column18",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column2",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column3",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column4",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column5",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column6",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column7",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column8",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Column9",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "IssizlikOrani",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
