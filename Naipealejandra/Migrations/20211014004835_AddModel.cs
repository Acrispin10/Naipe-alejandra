using Microsoft.EntityFrameworkCore.Migrations;

namespace Naipealejandra.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Naipe",
                columns: table => new
                {
                    IdNaipe = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    NombreNaipe = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LinkNaipe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naipe", x => x.IdNaipe);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Naipe");
        }
    }
}
