using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial1_Ap1_VladimirGuzman.Migrations
{
    /// <inheritdoc />
    public partial class CambiandodatoMontoatipofloat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Monto",
                table: "Metas",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Monto",
                table: "Metas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");
        }
    }
}
