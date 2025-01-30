using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VistaMatematicasGet(int num1, int num2)
        {
            ViewData["NUM1"] = num1;
            ViewData["NUM2"] = num2;

            int suma = num1 + num2;
            ViewData["SUMA"] = suma;

            return View();
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost (int num1, int num2)
        {
            ViewData["DATA"] = "La suma de " + num1 + " + " + num2 + " = " + (num1 + num2);
            return View();
        }
        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            //DEBEMOS DEVOLVER UN OBJETO COMPLEJO CON UNA LISTA DE NUMEROS
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            //devolvemos la lista a la vista 
            return View(numeros);
        }

        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarSimple(int numero)
        {
            List<int> numeros = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                int mult = numero * i;
                numeros.Add(mult);
            }
            return View(numeros);
        }

        public IActionResult TablaMultiplicarModel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TablaMultiplicarModel(int numero)
        {
            List<FilaTablaMultiplicar> filas = new List<FilaTablaMultiplicar>();
            for (int i = 0; i <=10 ; i++)
            {
                FilaTablaMultiplicar fila =
            new FilaTablaMultiplicar();
                fila.Operacion = numero + " * " + i;
                fila.Resultado = numero * i;
                filas.Add(fila);
            }
            return View(filas);
        
        }
    }
}
