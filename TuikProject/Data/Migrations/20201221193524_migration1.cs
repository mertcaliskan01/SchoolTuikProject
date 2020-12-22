using Microsoft.EntityFrameworkCore.Migrations;

namespace TuikProject.Data.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssizlikOraniTablo1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Toplam2019 = table.Column<string>(nullable: true),
                    Toplam2020 = table.Column<string>(nullable: true),
                    Erkek2019 = table.Column<string>(nullable: true),
                    Erkek2020 = table.Column<string>(nullable: true),
                    Kadın2019 = table.Column<string>(nullable: true),
                    Kadın2020 = table.Column<string>(nullable: true),
                    ToplamOran2019 = table.Column<string>(nullable: true),
                    ToplamOran2020 = table.Column<string>(nullable: true),
                    ErkekOran2019 = table.Column<string>(nullable: true),
                    ErkekOran2020 = table.Column<string>(nullable: true),
                    KadınOran2019 = table.Column<string>(nullable: true),
                    KadınOran2020 = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssizlikOraniTablo1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(nullable: true),
                    IsAnaBaslik = table.Column<bool>(nullable: false),
                    AnaBaslikId = table.Column<int>(nullable: false),
                    AltBaslikUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssizlikOraniTablo1");

            migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
