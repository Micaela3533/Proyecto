using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;
using System.Data;

namespace Proyecto.Data
{
    public class PeliculaData
    {


        private static Pelicula ObtenerPorRow(DataRow row)
        {
            Pelicula p = new Pelicula();
            p.Id = row.Field<int>("idpelicula");
            p.Nombre = row.Field<string>("nombre");
            p.Año = row.Field<int>("año");
            p.Descripcion = row.Field<string>("descripcion");
            p.Imagen = row.Field<string>("imagen");
            p.Duracion = row.Field<int>("duracion");
            p.Genero = row.Field<string>("generos");
            return p;
        }

        public static List<Pelicula> ObtenerCarousel()
        {
            string select = "select * from peliculas  order by idpelicula desc limit 3";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;
        }
        public static List<Pelicula> ObtenerTodas()
        {
            string select = "select * from peliculas";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;
        }

        public static List<Pelicula> ObtenerPorGenero(int idGenero)
        {
            string select = "select distinct p.idpelicula, p.nombre, p.año, p.descripcion, p.imagen, p.duracion, p.generos" +
                " from peliculas p inner join peliculaxgenero pg on p.idpelicula=pg.idpelicula and pg.idgenero=" + idGenero;
                
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;

        }
        public static List<Pelicula> ObtenerAccion()
        {
            string select = "select * from peliculas where generos like '%Accion%' ";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;

        }
        public static List<Pelicula> ObtenerCFiccion()
        {
            string select = "select * from peliculas where generos like '%Ciencia Ficcion%' ";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;

        }

        public static List<Pelicula> ObtenerFantasia()
        {
            string select = "select * from peliculas where generos like '%Fantasia%' ";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;

        }
        public static List<Pelicula> ObtenerAventura()
        {
            string select = "select * from peliculas where generos like '%Aventura%' ";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;

        }
        public static List<Pelicula> ObtenerThriller()
        {
            string select = "select * from peliculas where generos like '%Thriller%' ";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;
        }
        public static List<Pelicula> ObtenerComedia()
        {
            string select = "select * from peliculas where generos like '%Comedia%' ";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;
        }
        public static List<Pelicula> ObtenerCrimen()
        {
            string select = "select * from peliculas where generos like '%Crimen%' ";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;
        }
        public static List<Pelicula> ObtenerAnimacion()
        {
            string select = "select * from peliculas where generos like '%Animacion%' ";
            DataTable dt = DBHelper.EjecutarSelect(select);
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            Pelicula p;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                    listaPeliculas.Add(p);
                }
                p = ObtenerPorRow(dt.Rows[0]);
            }
            return listaPeliculas;
        }

        public static Pelicula BuscarPorId(int id)
        {
            string select = "select * from peliculas where idpelicula =" + id;
            DataTable dt = DBHelper.EjecutarSelect(select);
            Pelicula p = new Pelicula();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    p = ObtenerPorRow(row);
                }
            }
            return p;

        }

    } 
    
}
