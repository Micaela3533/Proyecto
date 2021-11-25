using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class MensajexSala
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string Usuario { get; set; }
        public string  Fecha { get; set; }
        public int IdSala { get; set; }

    }
}