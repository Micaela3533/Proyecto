using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Proyecto.Models;

namespace Proyecto.Data
{
    public class GeneroData
    {
        private static Genero ObtenerPorRow(DataRow row)
        {
            Genero g = new Genero
            {
                Id = row.Field<int>("id"),
                Nombre = row.Field<string>("nombre"),
                Gif = row.Field<string>("gif")
            };
            return g;
        }
        public static List<Genero> ObtenerGeneros()
        {
            string select = "select * from generos limit 5";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Genero> listageneros = new List<Genero>();
            Genero g;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    g = ObtenerPorRow(row);
                    listageneros.Add(g);
                }
                g = ObtenerPorRow(dt.Rows[0]);
            }
            return listageneros;
        }

        public static Genero ObtenerGenero(int idGenero)
        {
            string select = "select * from generos  where id=" + idGenero;
            DataTable dt = DBHelper.EjecutarSelect(select);
            Genero g=null;
            if (dt.Rows.Count > 0)
            {                                
                g = ObtenerPorRow(dt.Rows[0]);                                                    
            }
            return g;
        }
    }
}