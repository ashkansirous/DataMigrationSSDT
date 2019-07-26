using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirst.Database.Migrations
{
    public partial class changeModuleLincensetoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ModuleLicenses",
                table: "ModuleConfiguration",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModuleLicenses",
                table: "ModuleConfiguration",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
