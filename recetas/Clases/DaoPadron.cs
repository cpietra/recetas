using Microsoft.IdentityModel.Protocols;
using Npgsql;
using recetas.Models;
using System;
using System.Data;

namespace recetas.Clases
{
    public class DaoPadron
    {
        public Boolean Insert_Padron(Padron padron)
        {
            Boolean retorno = false;
            try
            {
                string connString = "Server=192.168.0.190;Port=5432;Database=recetas;User Id=postgres;Password=aliciad2102;";
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = connString; // ConfigurationManager.ConnectionStrings["constr"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand
                    {
                        Connection = connection,
                        CommandText = "INSERT INTO padron(plan,categoria,numero,orden,tipo_doc,num_doc,nombre,sexo,ecivil," +
                        "f_nacimiento,nacionalidad,parentesco,vive_calle,vive_numero,vive_piso,vive_depto,vive_cod_postal,vive_localidad_texto," +
                        "vive_localidad,vive_partido,vive_provincia,telefono,movil,email,f_ingreso,prepaga_anterior,f_egreso,prepaga_proxima," +
                        "volveria,motivo_baja_miembro,motivo_baja_miembro_agrupado,cobrador,zona,f_alta_grupo,f_antiguedad1,promotor,tipo_grupo," +
                        "presento,f_baja,motivo_baja_grupo,motivo_baja_agrupado_grupo,paciente_cronico) values(@Plan,@Categoria,@Numero,@Orden,@Tipo_doc,@Num_doc,@Nombre," +
                        "@Sexo,@Ecivil,@F_nacimiento,@Nacionalidad,@Parentesco,@Vive_calle,@Vive_numero,@Vive_piso,@Vive_depto,@Vive_cod_postal,@Vive_localidad_texto," +
                        "@Vive_localidad,@Vive_partido,@Vive_provincia,@Telefono,@Movil,@Email,@F_ingreso,@Prepaga_anterior,@F_egreso,@Prepaga_proxima,@Volveria," +
                        "@Motivo_baja_miembro,@Motivo_baja_miembro_agrupado,@Cobrador,@Zona,@F_alta_grupo,@F_antiguedad1,@Promotor,@Tipo_grupo,@Presento,@F_baja," +
                        "@Motivo_baja_grupo,@Motivo_baja_agrupado_grupo,@Paciente_Cronico)",
                        CommandType = CommandType.Text
                    };
                    //cmd.Parameters.Add(new NpgsqlParameter("@Id_Padron", padron.Id_Padron));
                    cmd.Parameters.Add(new NpgsqlParameter("@Plan", padron.Plan));
                    cmd.Parameters.Add(new NpgsqlParameter("@Categoria", padron.Categoria));
                    cmd.Parameters.Add(new NpgsqlParameter("@Numero", padron.Numero));
                    cmd.Parameters.Add(new NpgsqlParameter("@Orden", padron.Orden));
                    cmd.Parameters.Add(new NpgsqlParameter("@Tipo_doc", padron.Tipo_doc));
                    cmd.Parameters.Add(new NpgsqlParameter("@Num_doc", padron.Num_doc));
                    cmd.Parameters.Add(new NpgsqlParameter("@Nombre", padron.Nombre));
                    cmd.Parameters.Add(new NpgsqlParameter("@Sexo", padron.Sexo));
                    cmd.Parameters.Add(new NpgsqlParameter("@Ecivil", padron.Ecivil));
                    cmd.Parameters.Add(new NpgsqlParameter("@F_nacimiento", padron.F_nacimiento));
                    cmd.Parameters.Add(new NpgsqlParameter("@Nacionalidad", padron.Nacionalidad));
                    cmd.Parameters.Add(new NpgsqlParameter("@Parentesco", padron.Parentesco));
                    cmd.Parameters.Add(new NpgsqlParameter("@Vive_calle", padron.Vive_calle));
                    cmd.Parameters.Add(new NpgsqlParameter("@Vive_numero", padron.Vive_numero));
                    cmd.Parameters.Add(new NpgsqlParameter("@Vive_piso", padron.Vive_piso));
                    cmd.Parameters.Add(new NpgsqlParameter("@Vive_depto", padron.Vive_depto));
                    cmd.Parameters.Add(new NpgsqlParameter("@Vive_cod_postal", padron.Vive_cod_postal));
                    cmd.Parameters.Add(new NpgsqlParameter("@Vive_localidad_texto", padron.Vive_localidad_texto));
                    cmd.Parameters.Add(new NpgsqlParameter("@Vive_localidad", padron.Vive_localidad));
                    cmd.Parameters.Add(new NpgsqlParameter("@Vive_partido", padron.Vive_partido));
                    cmd.Parameters.Add(new NpgsqlParameter("@Vive_provincia", padron.Vive_provincia));
                    cmd.Parameters.Add(new NpgsqlParameter("@Telefono", padron.Telefono));
                    cmd.Parameters.Add(new NpgsqlParameter("@Movil", padron.Movil ));
                    cmd.Parameters.Add(new NpgsqlParameter("@Email", padron.Email));
                    cmd.Parameters.Add(new NpgsqlParameter("@F_ingreso", padron.F_ingreso));
                    cmd.Parameters.Add(new NpgsqlParameter("@Prepaga_anterior", padron.Prepaga_anterior));
                    cmd.Parameters.Add(new NpgsqlParameter("@F_egreso", padron.F_egreso));
                    cmd.Parameters.Add(new NpgsqlParameter("@Prepaga_proxima", padron.Prepaga_proxima));
                    cmd.Parameters.Add(new NpgsqlParameter("@Volveria", padron.Volveria));
                    cmd.Parameters.Add(new NpgsqlParameter("@Motivo_baja_miembro", padron.Motivo_baja_miembro));
                    cmd.Parameters.Add(new NpgsqlParameter("@Motivo_baja_miembro_agrupado", padron.Motivo_baja_miembro_agrupado));
                    cmd.Parameters.Add(new NpgsqlParameter("@Cobrador", padron.Cobrador));
                    cmd.Parameters.Add(new NpgsqlParameter("@Zona", padron.Zona));
                    cmd.Parameters.Add(new NpgsqlParameter("@F_alta_grupo", padron.F_alta_grupo));
                    cmd.Parameters.Add(new NpgsqlParameter("@F_antiguedad1", padron.F_antiguedad1));
                    cmd.Parameters.Add(new NpgsqlParameter("@Promotor", padron.Promotor));
                    cmd.Parameters.Add(new NpgsqlParameter("@Tipo_grupo", padron.Tipo_grupo));
                    cmd.Parameters.Add(new NpgsqlParameter("@Presento", padron.Presento));
                    cmd.Parameters.Add(new NpgsqlParameter("@F_baja", padron.F_baja));
                    cmd.Parameters.Add(new NpgsqlParameter("@Motivo_baja_grupo", padron.Motivo_baja_grupo));
                    cmd.Parameters.Add(new NpgsqlParameter("@Motivo_baja_agrupado_grupo", padron.Motivo_baja_agrupado_grupo));
                    cmd.Parameters.Add(new NpgsqlParameter("@Paciente_Cronico", padron.Paciente_Cronico));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // something went wrong, and you wanna know why
                throw;
            }
            return retorno;
        }
    }
}
