﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TuikProject.Data.Migrations
{
    public partial class migrationFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssizlikOrani",
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
                    Column18 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssizlikOrani", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssizlikOrani");
        }
    }
}