using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EjemploMVC.Models;
using System.Web.Mvc;

namespace EjemploMVC.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        //POST: PRUEBA/INDEX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Calculo obCalculo) {
            //suma
            int resultado = obCalculo.numero1 + obCalculo.numero2;
            ViewBag.resultado = resultado;
            //resta
            int resultadoR = obCalculo.numero1 - obCalculo.numero2;
            ViewBag.resultadoR = resultadoR;
            //Multi
            int resultadoM = obCalculo.numero1 * obCalculo.numero2;
            ViewBag.resultadoM = resultadoM;
            //Div
            int resultadoD = obCalculo.numero1 / obCalculo.numero2;
            ViewBag.resultadoD = resultadoD;

            return View(obCalculo);
        }
    }
}