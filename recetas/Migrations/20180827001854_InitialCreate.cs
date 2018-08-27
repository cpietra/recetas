using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace recetas.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "medicamentos",
                columns: table => new
                {
                    Id_medicamento = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Atc = table.Column<string>(nullable: true),
                    Generico = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Presentacion = table.Column<string>(nullable: true),
                    Pvp = table.Column<double>(nullable: false),
                    Acargoos = table.Column<double>(nullable: false),
                    Acargoafil = table.Column<double>(nullable: false),
                    Laboratorio = table.Column<string>(nullable: true),
                    Registro = table.Column<double>(nullable: false),
                    Pr = table.Column<double>(nullable: false),
                    Plan = table.Column<string>(nullable: true),
                    Grupoter = table.Column<double>(nullable: false),
                    Obser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamentos", x => x.Id_medicamento);
                });

            migrationBuilder.CreateTable(
                name: "padron",
                columns: table => new
                {
                    Id_Padron = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Plan = table.Column<string>(nullable: true),
                    Categoria = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Orden = table.Column<int>(nullable: false),
                    Tipo_doc = table.Column<string>(nullable: true),
                    Num_doc = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Ecivil = table.Column<string>(nullable: true),
                    F_nacimiento = table.Column<DateTime>(nullable: false),
                    Nacionalidad = table.Column<string>(nullable: true),
                    Parentesco = table.Column<string>(nullable: true),
                    Vive_calle = table.Column<string>(nullable: true),
                    Vive_numero = table.Column<string>(nullable: true),
                    Vive_piso = table.Column<string>(nullable: true),
                    Vive_depto = table.Column<string>(nullable: true),
                    Vive_cod_postal = table.Column<string>(nullable: true),
                    Vive_localidad_texto = table.Column<string>(nullable: true),
                    Vive_localidad = table.Column<string>(nullable: true),
                    Vive_partido = table.Column<string>(nullable: true),
                    Vive_provincia = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Movil = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    F_ingreso = table.Column<DateTime>(nullable: false),
                    Prepaga_anterior = table.Column<string>(nullable: true),
                    F_egreso = table.Column<DateTime>(nullable: false),
                    Prepaga_proxima = table.Column<string>(nullable: true),
                    Volveria = table.Column<string>(nullable: true),
                    Motivo_baja_miembro = table.Column<string>(nullable: true),
                    Motivo_baja_miembro_agrupado = table.Column<string>(nullable: true),
                    Cobrador = table.Column<string>(nullable: true),
                    Zona = table.Column<string>(nullable: true),
                    F_alta_grupo = table.Column<DateTime>(nullable: false),
                    F_antiguedad1 = table.Column<DateTime>(nullable: false),
                    Promotor = table.Column<string>(nullable: true),
                    Tipo_grupo = table.Column<string>(nullable: true),
                    Presento = table.Column<string>(nullable: true),
                    F_baja = table.Column<DateTime>(nullable: false),
                    Motivo_baja_grupo = table.Column<string>(nullable: true),
                    Motivo_baja_agrupado_grupo = table.Column<string>(nullable: true),
                    Paciente_Cronico = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_padron", x => x.Id_Padron);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "medicamentos");

            migrationBuilder.DropTable(
                name: "padron");
        }
    }
}
