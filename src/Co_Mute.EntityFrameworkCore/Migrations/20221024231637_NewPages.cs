using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Co_Mute.Migrations
{
    public partial class NewPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "AppCarpools",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "AppCarpools");
        }
    }
}
