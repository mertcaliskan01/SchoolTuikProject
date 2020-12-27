using Microsoft.EntityFrameworkCore.Migrations;

namespace TuikProject.Data.Migrations
{
    public partial class migrationThird : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssizlikOraniT1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(nullable: true),
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
                    IssizlikOraniId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssizlikOraniT1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssizlikOraniT1_IssizlikOrani_IssizlikOraniId",
                        column: x => x.IssizlikOraniId,
                        principalTable: "IssizlikOrani",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IssizlikOraniT1_IssizlikOraniId",
                table: "IssizlikOraniT1",
                column: "IssizlikOraniId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssizlikOraniT1");
        }
    }
}
