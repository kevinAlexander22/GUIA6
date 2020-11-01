using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EjemploMVC.Models;
using System.Web.Mvc;

namespace EjemploMVC.Controllers
{
    public class ConversionesController : Controller
    {
        // GET: Conversiones
        public ActionResult Conversiones()
        {
            return View();
        }
         //POST: PRUEBA/INDEX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Conversiones(TiposCalculo obCalculo) {            
            /////temperatura
            double resultadoC = obCalculo.temperatura - 273.15;
            ViewBag.resultadoC = resultadoC;

            double resultadoK =obCalculo.temperatura + 273.15;
            ViewBag.resultadoK = resultadoK;

            ///Peso/////
            //kilos
            double resultadoKg = obCalculo.peso * 2.2;
            ViewBag.resultadoKg = resultadoKg;
            //libras
            double resultadolb = obCalculo.peso * 0.45;
            ViewBag.resultadolb = resultadolb;
            //longitud
            double resultadomt = obCalculo.longitud * 39.37;
            ViewBag.resultadomt = resultadomt;
            return View(obCalculo);
        }
    }
}