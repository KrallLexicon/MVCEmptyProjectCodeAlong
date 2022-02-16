using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCEmptyProject.Migrations
{
    public partial class AddedCarOwnertableandcreatedrelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarOwners",
                columns: table => new
                {
                    CarRegNumber = table.Column<string>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOwners", x => new { x.CarRegNumber, x.OwnerId });
                    table.ForeignKey(
                        name: "FK_CarOwners_Cars_CarRegNumber",
                        column: x => x.CarRegNumber,
                        principalTable: "Cars",
                        principalColumn: "RegNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarOwners_People_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarOwners_OwnerId",
                table: "CarOwners",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarOwners");
        }
    }
}
