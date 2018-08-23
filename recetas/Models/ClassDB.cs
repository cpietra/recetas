using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace recetas.Models
{
    public class Padron
    {
        [Key]
        public int Id_Padron { get; set; }
        public string Plan { get; set; }
        public string Categoria { get; set; }
        public int Numero { get; set; }
        public int Orden { get; set; }
        public string Tipo_doc { get; set; }
        public string Num_doc { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string Ecivil { get; set; }
        public DateTime F_nacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Parentesco { get; set; }
        public string Vive_calle { get; set; }
        public string Vive_numero { get; set; }
        public string Vive_piso { get; set; }
        public string Vive_depto { get; set; }
        public string Vive_cod_postal { get; set; }
        public string Vive_localidad_texto { get; set; }
        public string Vive_localidad { get; set; }
        public string Vive_partido { get; set; }
        public string Vive_provincia { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public DateTime F_ingreso { get; set; }
        public string Prepaga_anterior { get; set; }
        public DateTime F_egreso { get; set; }
        public string Prepaga_proxima { get; set; }
        public string Volveria { get; set; }
        public string Motivo_baja_miembro { get; set; }
        public string Motivo_baja_miembro_agrupado { get; set; }
        public string Cobrador { get; set; }
        public string Zona { get; set; }
        public DateTime F_alta_grupo { get; set; }
        public DateTime F_antiguedad1 { get; set; }
        public string Promotor { get; set; }
        public string Tipo_grupo { get; set; }
        public string Presento { get; set; }
        public DateTime F_baja { get; set; }
        public string Motivo_baja_grupo { get; set; }
        public string Motivo_baja_agrupado_grupo { get; set; }
        public List<Padron> List_Procesos { get; set; } = new List<Padron>();
    }

    public class Medicamentos
    {
        [Key]
        public int Id_medicamento { get; set; }
        public string Atc { get; set; }
        public string Generico { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public Double Pvp { get; set; }
        public Double Acargoos { get; set; }
        public Double Acargoafil { get; set; }
        public string Laboratorio { get; set; }
        public Double Registro { get; set; }
        public Double Pr { get; set; }
        public string Plan { get; set; }
        public Double Grupoter { get; set; }
        public string Obser { get; set; }
    }

    public class RecetasContext : DbContext
    {
        public RecetasContext(DbContextOptions<RecetasContext> options)
            : base(options)
        { }

        public DbSet<Padron> Procesos { get; set; }
        public DbSet<Medicamentos> Registros { get; set; }
    }
}
