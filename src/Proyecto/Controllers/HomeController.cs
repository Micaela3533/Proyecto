using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Data;
using System.Data.SqlClient;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            //ViewBag.codigo = CrearSalas.Llenar();
            ViewBag.lista = PeliculaData.ObtenerCarousel();
            ViewBag.Generos  =  GeneroData.ObtenerGeneros();
            return View();

        }

        public ActionResult Peliculas()
        {
            ViewBag.Todas = PeliculaData.ObtenerTodas();
            return View();
        }
        public ActionResult PeliIndi()
        {
            //ViewBag.lista = PeliculaData.ObtenerTodas();
            return View();
        }


        public ActionResult Genero(int idGenero)
        {
            ViewBag.lista = PeliculaData.ObtenerCarousel();
            ViewBag.Titulo = GeneroData.ObtenerGenero(idGenero).Nombre;
            ViewBag.Peliculas = PeliculaData.ObtenerPorGenero(idGenero);
            return View();
        }

        public ActionResult DetallePelicula(int id)
        {
            Pelicula peli=PeliculaData.BuscarPorId(id);
            ViewBag.Imagen = peli.Imagen;
            ViewBag.titulo = peli.Nombre;
            ViewBag.Descripcion = peli.Descripcion;
            ViewBag.Duracion = peli.Duracion;
            ViewBag.año = peli.Año;
            ViewBag.genero = peli.Genero; 
            return View("CrearSala");
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult DetallePelicula(string Nombre)
        {
            ViewBag.Codigo = CrearSalas.Codigo(Nombre);
            Sala id = EntrarSala.BuscaridSala(ViewBag.Codigo);
            TempData["idSala"] = id.Id;
            if (TempData.ContainsKey("idSala"))
            {
                ViewBag.id = int.Parse(TempData["idSala"].ToString());
            }

            ViewBag.Nombre = Nombre;
            return View("SalaCreada");
        }     
     

        public ActionResult EntrarSalas()
        {
            return View("EntrarSalas");
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult EntrarSalas( string mensaje, string nombre , int codigo )
        {
            bool encontrado = EntrarSala.Verificar(codigo, nombre);
            Sala id = EntrarSala.BuscaridSala(codigo);
            TempData["idSala"] = id.Id;
            TempData["Nick"] = nombre;
            TempData["Codigo"] = codigo;


            if (TempData.ContainsKey("idSala"))
            {
                ViewBag.id = int.Parse(TempData["idSala"].ToString());
            }
            if (TempData.ContainsKey("Nick"))
            {
                ViewBag.Nick = TempData["Nick"].ToString();
            }
            if (TempData.ContainsKey("Codigo"))
            {
                ViewBag.Codigo = TempData["Codigo"].ToString();
            }




            if (encontrado == true)
            {
                return View("SalaCreada");
            }
            else
            {
                ViewBag.Mensaje = "Los datos ingresados no son correctos";
                return View();
            }



        }

        public ActionResult CrearSala()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CrearSala(string mensaje)
        {
            //MensajeData.Insertar(mensaje);
            return View();
        }

        public ActionResult SalaCreada()
        {

            
            return View();
        }



        [HttpGet]
        public IList<MensajexSala> GetMensajexSalas(int idSala) 
        {
            return MensajeData.ObtenerMensajesxSala(idSala);
        }
    }
}
