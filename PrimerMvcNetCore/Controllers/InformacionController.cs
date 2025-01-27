using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ControladorVista()
        {
            //vamos a enviar informacion simple a nuestra vista
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 23;
            ViewBag.DiaSemana = "Lunes";
            //enviar informacion compleja -> Model

            return View();
        }
        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Email = "alumno@email.com";
            persona.Edad = 23;
            return View(persona);
        }
    }
}
