using ProyectoIntegrado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoIntegrado.Controllers
{
    public class HomeController : Controller
    {
        PROYECTOINTEGRADOEntities cnx;
        public HomeController()
        {
            cnx = new PROYECTOINTEGRADOEntities();
        }
        public ActionResult Guarda(string rut, string nombre, string predio, string comuna, string tipo, int telefono, string direccion, string email)
        {

            ProyectoIntegrado.Models.CLIENTES ingresoclientes = new ProyectoIntegrado.Models.CLIENTES()
            {
                Rut = rut,
                Nombre = nombre,
                Predio = predio,
                Comuna = comuna,
                Tipo = tipo,
                Telefono = telefono,
                Direccion = direccion,
                Email = email
            };

            cnx.CLIENTES.Add(ingresoclientes);
            cnx.SaveChanges();

            return View("Listado", ListadoClientes());
        }
        public ActionResult GuardarAnalisis(string tipoanalisis, string nombreanalisis)
        {

            ProyectoIntegrado.Models.TIPOANALISIS ingresoanalisis = new ProyectoIntegrado.Models.TIPOANALISIS()
            {
                TipoAnalisis1 = tipoanalisis,
                NombreAnalisis = nombreanalisis
            };

            cnx.TIPOANALISIS.Add(ingresoanalisis);
            cnx.SaveChanges();

            return View("Listado", ListadoAnalisis());
        }
        public ActionResult MenuPrincipal()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Clientes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Analisis()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Mantenimiento()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private List<ProyectoIntegrado.Models.CLIENTES> ListadoClientes()
        {

            cnx.Database.Connection.Open();
            List<ProyectoIntegrado.Models.CLIENTES> vacas = cnx.CLIENTES.ToList();

            cnx.Database.Connection.Close();

            return vacas;
        }
        private List<ProyectoIntegrado.Models.TIPOANALISIS> ListadoAnalisis()
        {

            cnx.Database.Connection.Open();
            List<ProyectoIntegrado.Models.TIPOANALISIS> vacas = cnx.TIPOANALISIS.ToList();

            cnx.Database.Connection.Close();

            return vacas;
        }
    }
}