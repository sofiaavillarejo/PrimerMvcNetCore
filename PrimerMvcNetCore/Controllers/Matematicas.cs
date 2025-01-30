using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class Matematicas : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VistaControllerGet (int num1, int num2)
        {
            ViewData["NUM1"] = num1;
            ViewData["NUM2"] = num2;

            int suma = num1 + num2;
            ViewData["SUMA"] = suma;

            return View();
        }
    }
}
