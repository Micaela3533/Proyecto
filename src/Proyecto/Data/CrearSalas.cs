using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;
using System.Data;

namespace Proyecto.Data
{
    public class CrearSalas
    {

        private static Sala ObtenerPorRow(DataRow row)
        {
            Sala s = new Sala();
            s.Nombre = row.Field<string>("nombre");
            s.Codigo = row.Field<int>("codigo");
            return s;
        }

        public static int Codigo(string nombre)
        {
            int min = 100000000;
            int max = 999999999;
            Random rdn = new Random();
            int a = rdn.Next(min, max);
            while (Verificar(a,nombre) == false)
            {
                a = rdn.Next(min, max);
            }
            return a;
        }

        public static bool Verificar(int Codigo,string nombre)
        {
            string select = "select* from codigo where codigo =" + Codigo;
            DataTable dt = DBHelper.EjecutarSelect(select);
            bool encontro = false;
            if (dt.Rows.Count == 0)
            {
                encontro = true;
                select = "insert into codigo value (" + Codigo + "," + nombre +")";
                DBHelper.EjecutarSelect(select);
            }
            return encontro;
        }
    }
}
