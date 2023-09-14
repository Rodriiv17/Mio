using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelos.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persona",
                columns: new[] { "Id", "FechaNacimiento", "Nombre", "Telefono", "UserName", "password" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "948230430", "Pedro", "password" },
                    { 2, new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "123456789", "Ana", "password" },
                    { 3, new DateTime(1990, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis", "987654321", "Luis", "password" },
                    { 4, new DateTime(1987, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "María", "555123789", "María", "password" },
                    { 5, new DateTime(2005, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "777888999", "Juan", "password" },
                    { 6, new DateTime(2002, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "333444555", "Laura", "password" },
                    { 7, new DateTime(1978, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "999111222", "Carlos", "password" },
                    { 8, new DateTime(1983, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marta", "444555666", "Marta", "password" },
                    { 9, new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrés", "888999000", "Andrés", "password" },
                    { 10, new DateTime(1970, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel", "222333444", "Isabel", "password" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
