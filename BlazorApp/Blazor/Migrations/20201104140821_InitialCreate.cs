using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Thematic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thematic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ArticleText = table.Column<string>(nullable: true),
                    CreateData = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    AutorID = table.Column<int>(nullable: true),
                    ThematicsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Article_Autors_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Autors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Thematic_ThematicsID",
                        column: x => x.ThematicsID,
                        principalTable: "Thematic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AutorID",
                table: "Article",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Article_ThematicsID",
                table: "Article",
                column: "ThematicsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Autors");

            migrationBuilder.DropTable(
                name: "Thematic");
        }
    }
}
