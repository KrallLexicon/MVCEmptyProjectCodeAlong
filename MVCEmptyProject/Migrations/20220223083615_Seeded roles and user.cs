using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCEmptyProject.Migrations
{
    public partial class Seededrolesanduser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afa924c3-e860-4c35-ba91-60e8792f351b", "502cc95d-dfee-4db4-9d07-b698452c9ff4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c27f0178-dff6-4f51-8997-a12a2d0d3092", "6c0bce1d-0261-4fb5-b072-43723a717044", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3006e1f9-2671-4e70-ba51-a4a548fcba72", 0, 294, "0333c335-5845-4f06-93e5-b0844e5847ea", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEEg/C9bdxujm8io2VGCm7k9yvDgpGsZuVQL4HYhD9Pvi7U+BM3XTLW37G5pnk6ghzQ==", null, false, "73128d41-77b0-4c65-bd6b-d32ba30d53d1", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3006e1f9-2671-4e70-ba51-a4a548fcba72", "afa924c3-e860-4c35-ba91-60e8792f351b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c27f0178-dff6-4f51-8997-a12a2d0d3092");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3006e1f9-2671-4e70-ba51-a4a548fcba72", "afa924c3-e860-4c35-ba91-60e8792f351b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afa924c3-e860-4c35-ba91-60e8792f351b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3006e1f9-2671-4e70-ba51-a4a548fcba72");
        }
    }
}
