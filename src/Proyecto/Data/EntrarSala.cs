using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;
using System.Data;

namespace Proyecto.Data
{
    public class EntrarSala
    {
        private static Sala ObtenerPorRow(DataRow row)
        {
            Sala s = new Sala();
            s.Id = row.Field<int>("idSala");
            s.Nombre = row.Field<string>("nombre");
            s.Codigo = row.Field<int>("codigo");
            return s;
        }

        public static bool Verificar(int Codigo, string nombre)
        {
            string select = "select * from codigo where codigo =" + Codigo;
            DataTable dt = DBHelper.EjecutarSelect(select);
            bool encontro = false;
            if (dt.Rows.Count != 0)
            {
                encontro = true;
            }
            return encontro;
        }
        public static Sala BuscaridSala (int codigo)
        {
            string select = "select * from codigo where codigo =" + codigo;
            DataTable dt = DBHelper.EjecutarSelect(select);
            Sala s = new Sala();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    s = ObtenerPorRow(row);
                }
            }
            return s;
        }


    }
}