using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirst.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Partner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModuleConfiguration",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TemplafyLicences = table.Column<int>(nullable: true),
                    SlideProofLicenses = table.Column<int>(nullable: true),
                    ModuleLicenses = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleConfiguration_Tenants_Id",
                        column: x => x.Id,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModuleConfiguration");

            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
