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
            //ViewBag.random = CrearSalas.Llenar();
            ViewBag.lista = PeliculaData.ObtenerCarousel();

            return View();

        }

        public ActionResult Peliculas()
        {
            var lista = PeliculaData.ObtenerTodas();
            return View();
        }

        public ActionResult Series()
        {

            return View();
        }
        public ActionResult IniciarSesion()
        {

            return View();
        }
        public ActionResult Registrarse()
        {

            return View();
        }
        public ActionResult CrearSala()
        {
            
            return View();
        }
        public ActionResult PeliIndi()
        {
            //ViewBag.lista = PeliculaData.ObtenerTodas();
            return View();
        }
        public ActionResult Accion()
        {
            ViewBag.Accion = PeliculaData.ObtenerAccion();
            return View();
        }
        public ActionResult CienciaFiccion()
        {
            ViewBag.CFiccion = PeliculaData.ObtenerCFiccion();
            return View();
        }
        public ActionResult Fantasia()
        {
            ViewBag.Fantasia = PeliculaData.ObtenerFantasia();
            return View();
        }
        public ActionResult Aventura()
        {
            ViewBag.Fantasia = PeliculaData.ObtenerAventura();
            return View();
        }
        public ActionResult Thriller()
        {
            ViewBag.Fantasia = PeliculaData.ObtenerThriller();
            return View();
        }
        public ActionResult Comedia()
        {
            ViewBag.Fantasia = PeliculaData.ObtenerComedia();
            return View();
        }
        public ActionResult Crimen()
        {
            ViewBag.Fantasia = PeliculaData.ObtenerCrimen();
            return View();
        }
        public ActionResult Animacion()
        {
            ViewBag.Fantasia = PeliculaData.ObtenerAventura();
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

    }
}
