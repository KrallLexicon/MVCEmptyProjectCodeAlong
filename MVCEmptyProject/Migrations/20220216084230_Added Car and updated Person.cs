using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCEmptyProject.Migrations
{
    public partial class AddedCarandupdatedPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    RegNumber = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: false),
                    CarModel = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.RegNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "People");
        }
    }
}
