using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_RESTCV.Migrations
{
    /// <inheritdoc />
    public partial class administradores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasenia", "CorreoElectronico", "Nombre", "Role" },
                values: new object[,]
                {
                    { 2, "admin123456", "javierdialf03@gmail.com", "El Administador Maestro", 0 },
                    { 3, "sabranellos", "ventanillaunica@siva.gov.co", "adminSIVA", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
