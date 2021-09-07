using System.Web.Mvc;
using Laboratorio3.Models;
using System;
using System.Collections.Generic;
using System.Web;
namespace Laboratorio3.Controllers { 
    public class CalculadoraIMCController : Controller {
           public ActionResult ResultadoIMC() {
                PersonaModel persona = new PersonaModel(1, "El bicho", 84.0, 1.87);
                double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
                ViewBag.IMC = IMC;
                ViewBag.persona = persona;
                return View();
            }


        public ActionResult ResultadosAleatoriosIMC() {
            List<PersonaModel> lista  =new  List<PersonaModel>();
            List<double> IMCLista = new List<double>();
            Random random = new Random();
            for (int i = 0; i < 30; i++) {
                lista.Add(new PersonaModel(i, "Sujeto de pruebas", random.NextDouble() * (150 - 20) + 20, random.NextDouble() * (2 - 1) + 1));
                IMCLista.Add(lista[i].Peso / (lista[i].Estatura * lista[i].Estatura));
            }
            ViewBag.IMCL = IMCLista;
            ViewBag.lista = lista;
            return View();
        }
    }
}