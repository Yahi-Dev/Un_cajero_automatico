using Microsoft.AspNetCore.Mvc;
using Tarea1_Leonardo.Enums;
using Tarea1_Leonardo.Models;
using Tarea1_Leonardo.Repositories;
using Tarea1_Leonardo.services;

namespace Tarea1_Leonardo.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly servicesDispensacion services;


        public ApplicationController(servicesDispensacion servicesDispensacion)
        {
            services = servicesDispensacion;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index1(DispensacionModels models)
        {
            services.Add(models);
            string modoDeDispesancion = services.GetModoDispensacion();
            var dispensacion = modoDeDispesancion;
            return RedirectToAction("Retiro", new {option = modoDeDispesancion});
        }

        
        public IActionResult Retiro(string option)
        {
            ViewBag.Retiro = option;
            return View();
        }

        [HttpPost]
        public IActionResult Retiro(int monto)
        {
            return RedirectToAction("Dispensacion", new {money = monto});
        }

        public IActionResult Dispensacion(int money)
        {
            string modoDeDispesancion = services.GetModoDispensacion();
            ViewBag.Retiro = modoDeDispesancion;
            ViewBag.Dispensacion = money;


            if (modoDeDispesancion == "Dispensacion Eficiente")
            {
                if (money <= 0 || money % 100 != 0)
                {
                    ViewBag.ErrorMessage = "El monto debe ser un numero entero mayor que cero y multiplo de 100, Ejemplo: 1000, 400, 800.";
                    return View("Index");
                }
                else
                {
                    ServicesBilletes _dispensacion = new ServicesBilletes();
                    int[] cantidad = _dispensacion.calculoDispensacion(modoDeDispesancion, money);
                    ViewBag.CantidadUno = cantidad[0];
                    ViewBag.CantidadDos = cantidad[1];
                    ViewBag.CantidadTres = cantidad[2];
                    ViewBag.CantidadCuatro = cantidad[3];
                    return View("Dispensacion");
                }
            }
            if (modoDeDispesancion == "Retirar de 200 y 1000")
            {
                int[] denominaciones = { 200, 1000 };

                if (money <= 0 || money % 100 != 0)
                {
                    ViewBag.ErrorMessage = "El monto debe ser un numero entero mayor que cero y multiplo de 100, Ejemplo: 1000, 400, 800.";
                    return View("Index");
                }
                bool cantidadAdecuada  = false;
                foreach (int denominacion in denominaciones)
                {
                    if (money % denominacion == 0)
                    {
                        cantidadAdecuada = true;
                        ServicesBilletes _dispensacion = new ServicesBilletes();
                        int[] cantidad = _dispensacion.calculoDispensacion(modoDeDispesancion, money);
                        ViewBag.CantidadDos = cantidad[1];
                        ViewBag.CantidadCuatro = cantidad[3];
                        return View("Dispensacion");
                    }
                }
                if (!cantidadAdecuada)
                {
                    ViewBag.ErrorMessage = "Este cajero solo dispensa billetes de 200 o 1000. Por favor, ingrese una cantidad adecuada.";
                    return View("Index");
                }
            }
            if (modoDeDispesancion == "Retirar de 100 y 500")
            {
                int[] denominaciones = { 100, 500 };

                if (money <= 0 || money % 100 != 0)
                {
                    ViewBag.ErrorMessage = "El monto debe ser un numero entero mayor que cero y multiplo de 100, Ejemplo: 1000, 400, 800.";
                    return View("Index");
                }
                bool cantidadAdecuada = false;
                foreach (int denominacion in denominaciones)
                {
                    if (money % denominacion == 0)
                    {
                        cantidadAdecuada = true;
                        ServicesBilletes _dispensacion = new ServicesBilletes();
                        int[] cantidad = _dispensacion.calculoDispensacion(modoDeDispesancion, money);
                        ViewBag.CantidadUno = cantidad[0];
                        ViewBag.CantidadTres = cantidad[2];
                        return View("Dispensacion");
                    }
                }
                if (!cantidadAdecuada)
                {
                    ViewBag.ErrorMessage = "Este cajero solo dispensa billetes de 100 o 500. Por favor, ingrese una cantidad adecuada.";
                    return View("Index");
                }
            }
            return View();
        }

        public IActionResult Privacy ()
        {
            return View();
        }

        public IActionResult IndexSigno()
        {
            return View();
        }


        [HttpPost]
        public IActionResult IndexSigno(int mes, int dia)
        {
            servicesSignoZodiacal servicesSigno = new servicesSignoZodiacal();
            string Signo = servicesSigno.GetSignoZodiacal(mes, dia);
            return RedirectToAction("ResultadoSigno", new {signo = Signo});
        }

        public IActionResult ResultadoSigno(string signo)
        {
            ViewBag.Signo = signo;
            return View();
        }

    }
}
