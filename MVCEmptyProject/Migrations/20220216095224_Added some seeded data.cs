using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCEmptyProject.Migrations
{
    public partial class Addedsomeseededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "RegNumber", "Brand", "CarModel" },
                values: new object[,]
                {
                    { "ABC-123", "Volvo", "V70" },
                    { "DEF-456", "SAAB", "93" },
                    { "GHI-789", "BMW", "E39" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "City", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 34, "Stenstorp", "Jonathan", "Krall" },
                    { 2, 58, "Anderstorp", "Anders", "Andersson" },
                    { 3, 37, "Kimstorp", "Kim", "Kimsson" }
                });

            migrationBuilder.InsertData(
                table: "CarOwners",
                columns: new[] { "CarRegNumber", "OwnerId" },
                values: new object[,]
                {
                    { "ABC-123", 1 },
                    { "GHI-789", 1 },
                    { "DEF-456", 2 },
                    { "ABC-123", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarOwners",
                keyColumns: new[] { "CarRegNumber", "OwnerId" },
                keyValues: new object[] { "ABC-123", 1 });

            migrationBuilder.DeleteData(
                table: "CarOwners",
                keyColumns: new[] { "CarRegNumber", "OwnerId" },
                keyValues: new object[] { "ABC-123", 3 });

            migrationBuilder.DeleteData(
                table: "CarOwners",
                keyColumns: new[] { "CarRegNumber", "OwnerId" },
                keyValues: new object[] { "DEF-456", 2 });

            migrationBuilder.DeleteData(
                table: "CarOwners",
                keyColumns: new[] { "CarRegNumber", "OwnerId" },
                keyValues: new object[] { "GHI-789", 1 });

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegNumber",
                keyValue: "ABC-123");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegNumber",
                keyValue: "DEF-456");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegNumber",
                keyValue: "GHI-789");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
