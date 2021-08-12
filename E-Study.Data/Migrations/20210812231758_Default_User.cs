using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Study.Data.Migrations
{
    public partial class Default_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "EmailConfirmed", "Enabled", "LastName", "Name", "Password", "userType" },
                values: new object[] { new Guid("98c4a5e4-4a8a-4316-81c5-db6c29a13989"), "gabrielbotinhoni@gmail.com", false, true, "Administrador", "Gabriel", "LiYXbO40kAVhixBcchUlwDCHJiA=", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("98c4a5e4-4a8a-4316-81c5-db6c29a13989"));
        }
    }
}
