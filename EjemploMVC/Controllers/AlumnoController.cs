using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EjemploMVC.Models;
using System.Web.Mvc;

namespace EjemploMVC.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Alumno()
        {
            return View();
        }
        //POST: PRUEBA/INDEX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alumno(Promedio obNotas)
        {
            double resultadoN = (obNotas.nota1 + obNotas.nota2 + obNotas.nota3) / 3;

            if (resultadoN == 10)
            {
                ViewBag.resultadoN = resultadoN + " Felicidades";
            }
            else if (resultadoN < 10 && resultadoN >= 7)
            {
                ViewBag.resultadoN =   resultadoN+ " Aprobado";
            }
            else if (resultadoN < 7 && resultadoN >= 4) {
                ViewBag.resultadoN =  resultadoN+ " Aplazado";
            }
            else if (resultadoN <= 4) {
                ViewBag.resultadoN =   resultadoN + " Visite un tutor";
            }

                return View(obNotas);
        }
    }
}