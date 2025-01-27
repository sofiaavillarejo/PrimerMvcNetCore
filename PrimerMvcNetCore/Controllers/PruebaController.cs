using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class PruebaController : Controller
    {
        //creamos metodo
        public IActionResult PrimeraPagina()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
