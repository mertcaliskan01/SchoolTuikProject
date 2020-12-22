using Microsoft.EntityFrameworkCore.Migrations;

namespace TuikProject.Data.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssizlikOraniTablo2",
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
                    Column19 = table.Column<string>(nullable: true),
                    Column20 = table.Column<string>(nullable: true),
                    Column21 = table.Column<string>(nullable: true),
                    Column22 = table.Column<string>(nullable: true),
                    Column23 = table.Column<string>(nullable: true),
                    Column24 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssizlikOraniTablo2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssizlikOraniTablo2");
        }
    }
}
