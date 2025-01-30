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
        //VAMOS A RECIBIR DOS PARÁMETROS
        public IActionResult VistaControllerGet (string saludo, int? year) //poniendo int? quitamos el "error" que aparecia en el if -> significa que es un int que admite nulos
        {
            //PARA COMPROBAR QUE LOS HEMOS RECIBIDO, LOS GUARDAMOS EN VIEWDATA PARA VER LA INFO
            //ViewData["DATA"] = "Hola " + saludo + " en el año " + year;

            if (year != null)//cuando preguntamos por el año que es un int, 
            {
                ViewData["DATA"] = "Hola " + saludo + " en el año " + year;
            }
            else
            {
                ViewData["DATA"] = "Aquí no tenemos tiempo...";
            }
            return View();
        }

        public IActionResult VistaControllerPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VistaControllerPost (Persona persona, string aficiones)
        {
            ViewData["DATA"] = "Nombre: " + persona.Nombre + ", Email: " + persona.Email + ", Edad: " + persona.Edad + ", Aficiones: " + aficiones;
            return View();
        }
    }
}
