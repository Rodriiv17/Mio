using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class FuncionCalcularEdadEnAnios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE ObtenerUltimasPersonasMayoresDe21
                            AS
                            BEGIN
                                SELECT TOP 10 *
                                FROM Personas
                                WHERE DATEDIFF(YEAR, FechaNacimiento, GETDATE()) >= 21
                                ORDER BY Nombre;
                            END
                        ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
