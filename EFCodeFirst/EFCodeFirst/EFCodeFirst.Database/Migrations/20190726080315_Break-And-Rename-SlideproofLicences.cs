using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirst.Database.Migrations
{
    public partial class BreakAndRenameSlideproofLicences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SlideProofLicenses",
                table: "ModuleConfiguration",
                newName: "ProductivityLicenses");

            migrationBuilder.AddColumn<int>(
                name: "CheckLincenses",
                table: "ModuleConfiguration",
                nullable: true);

            //Not scaffolding! Added by me:
            migrationBuilder.Sql($"update ModuleConfiguration set {nameof(ModuleConfiguration.CheckLincenses)} = {nameof(ModuleConfiguration.ProductivityLicenses)}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckLincenses",
                table: "ModuleConfiguration");

            migrationBuilder.RenameColumn(
                name: "ProductivityLicenses",
                table: "ModuleConfiguration",
                newName: "SlideProofLicenses");
        }
    }
}
