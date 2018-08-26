using recetas.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace recetas.Clases
{
    public class ImportarPadron
    {
        public List<Padron> List_Padron(string file)
        {
            StreamReader objReader = new StreamReader(file);
            string sLine = "";
            List<Padron> Return_list = new List<Padron>();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null && sLine !="")
                {
                    string[] fields = sLine.Split(',');
                    if (fields[0] != "plan")
                    {
                        if (fields[2].Trim() != "")
                        {
                            Padron Padron1 = new Padron();
                            Padron1.Plan = fields[0].ToString().Trim();
                            Padron1.Categoria = fields[1].ToString().Trim();
                            if (fields[2].Trim() != "") { Padron1.Numero = Convert.ToInt32(fields[2].ToString().Trim()); }
                            if (fields[3].Trim() != "") { Padron1.Orden = Convert.ToInt32(fields[3].ToString().Trim()); }
                            Padron1.Tipo_doc = fields[4].ToString().Trim();
                            Padron1.Num_doc = fields[5].ToString().Trim();
                            Padron1.Nombre = fields[6].ToString().Trim();
                            Padron1.Sexo = fields[7].ToString().Trim();
                            Padron1.Ecivil = fields[8].ToString().Trim();
                            if (fields[9].Trim() != "") { Padron1.F_nacimiento = DateTime.ParseExact(fields[9].ToString().Trim(), "dd/MM/yyyy", null); }
                            Padron1.Nacionalidad = fields[10].ToString().Trim();
                            Padron1.Parentesco = fields[11].ToString().Trim();
                            Padron1.Vive_calle = fields[12].ToString().Trim();
                            Padron1.Vive_numero = fields[13].ToString().Trim();
                            Padron1.Vive_piso = fields[14].ToString().Trim();
                            Padron1.Vive_depto = fields[15].ToString().Trim();
                            Padron1.Vive_cod_postal = fields[16].ToString().Trim();
                            Padron1.Vive_localidad_texto = fields[17].ToString().Trim();
                            Padron1.Vive_localidad = fields[18].ToString().Trim();
                            Padron1.Vive_partido = fields[19].ToString().Trim();
                            Padron1.Vive_provincia = fields[20].ToString().Trim();
                            Padron1.Telefono = fields[21].ToString().Trim();
                            Padron1.Movil = fields[22].ToString().Trim();
                            Padron1.Email = fields[23].ToString().Trim();
                            if (fields[24].Trim() != "") { Padron1.F_ingreso = DateTime.ParseExact(fields[24].ToString().Trim(), "dd/MM/yyyy", null); }
                            Padron1.Prepaga_anterior = fields[25].ToString().Trim();
                            if (fields[26].Trim() != "") { Padron1.F_egreso = DateTime.ParseExact(fields[26].ToString().Trim(), "dd/MM/yyyy", null); }
                            Padron1.Prepaga_proxima = fields[27].ToString().Trim();
                            Padron1.Volveria = fields[28].ToString().Trim();
                            Padron1.Motivo_baja_miembro = fields[29].ToString().Trim();
                            Padron1.Motivo_baja_miembro_agrupado = fields[30].ToString().Trim();
                            Padron1.Cobrador = fields[31].ToString().Trim();
                            Padron1.Zona = fields[32].ToString().Trim();
                            if (fields[33].Trim() != "") { Padron1.F_alta_grupo = DateTime.ParseExact(fields[33].ToString().Trim(), "dd/MM/yyyy", null); }
                            if (fields[34].Trim() != "") { Padron1.F_antiguedad1 = DateTime.ParseExact(fields[34].ToString().Trim(), "dd/MM/yyyy", null); }
                            Padron1.Promotor = fields[35].ToString().Trim();
                            Padron1.Tipo_grupo = fields[36].ToString().Trim();
                            Padron1.Presento = fields[37].ToString().Trim();
                            if (fields[38].Trim() != "") { Padron1.F_baja = DateTime.ParseExact(fields[38].ToString().Trim(), "dd/MM/yyyy", null); }
                            Padron1.Motivo_baja_grupo = fields[39].ToString().Trim();
                            Padron1.Motivo_baja_agrupado_grupo = fields[40].ToString().Trim();
                            Return_list.Add(Padron1);
                        }
                    }
                }                    
            }
            objReader.Close();
            return Return_list;
        }

    }
}
