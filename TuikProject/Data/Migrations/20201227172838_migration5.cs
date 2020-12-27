using Microsoft.EntityFrameworkCore.Migrations;

namespace TuikProject.Data.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableName",
                table: "IssizlikOraniT1");

            migrationBuilder.CreateTable(
                name: "IssizlikOraniT2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Column1 = table.Column<string>(nullable: true),
                    Column2 = table.Column<string>(nullable: true),
                    Column3 = table.Column<string>(nullable: true),
                    Column4 = table.Column<string>(nullable: true),
                    Column5 = table.Column<string>(nullable: true),
                    Column6 = table.Column<string>(nullable: true),
                    Column7 = table.Column<string>(nullable: true),
                    Column8 = table.Column<string>(nullable: true),
                    Column9 = table.Column<string>(nullable: true),
                    Column10 = table.Column<string>(nullable: true),
                    Column11 = table.Column<string>(nullable: true),
                    Column12 = table.Column<string>(nullable: true),
                    Column13 = table.Column<string>(nullable: true),
                    Column14 = table.Column<string>(nullable: true),
                    Column15 = table.Column<string>(nullable: true),
                    Column16 = table.Column<string>(nullable: true),
                    Column17 = table.Column<string>(nullable: true),
                    Column18 = table.Column<string>(nullable: true),
                    IssizlikOraniId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssizlikOraniT2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssizlikOraniT2_IssizlikOrani_IssizlikOraniId",
                        column: x => x.IssizlikOraniId,
                        principalTable: "IssizlikOrani",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IssizlikOraniT2_IssizlikOraniId",
                table: "IssizlikOraniT2",
                column: "IssizlikOraniId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssizlikOraniT2");

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "IssizlikOraniT1",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
