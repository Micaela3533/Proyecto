using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;
using System.Data;

namespace Proyecto.Data
{
    public class MensajeData
    {

        private static MensajexSala ObtenerPorRow(DataRow row)
        {
            MensajexSala m = new MensajexSala();
            m.Id = row.Field<int>("id");
            m.Texto = row.Field<string>("texto");
            m.IdSala = row.Field<int>("idSala");
            m.Fecha = row.Field<DateTime>("fecha");
            m.Usuario = row.Field<string>("usuario");
            return m;
        }

        public static void Insertar(string texto, string idUsuario, int idSala, DateTime fecha)
        {

            string insert = "INSERT INTO `krillo`.`mensajexsala` (`texto`, `usuario`, `fecha`, `idSala`) " +
                "VALUES ('"+ texto + "', '" + idUsuario + "', '" + fecha.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + idSala + "')";
            DBHelper.EjecutarIUD(insert);
        }

        public static IList<MensajexSala> ObtenerMensajesxSala(int idSala)
        {

            string select = $"select * from mensajexsala m where m.idSala={idSala}";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<MensajexSala> listaMensajes = new List<MensajexSala>();
            foreach (DataRow row in dt.Rows)
            {
                MensajexSala m = ObtenerPorRow(row);
                listaMensajes.Add(m);
            }
            return listaMensajes;

        }

    }
}