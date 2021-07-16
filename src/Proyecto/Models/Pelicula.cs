using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public int Año { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public int Duracion { get; set; }
        public string Genero { get; set; }
   
        
    }

}