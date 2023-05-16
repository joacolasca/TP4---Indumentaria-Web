using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View();
    }

    public IActionResult GuardarIndumentaria(int Equipo, int Media, int Pantalon, int Remera)
    {
        if(Media == null || Pantalon == null || Remera == null)
        {
            ViewBag.Error = "ERROR";
            ViewBag.ListaEquipos = Equipos.ListaEquipos;
            ViewBag.ListaMedias = Equipos.ListaMedias;
            ViewBag.ListaPantalones = Equipos.ListaPantalones;
            ViewBag.ListaRemeras = Equipos.ListaRemeras;
            return ViewBag.Error;
        }
        else
        {
            Indumentaria unaIndumentaria= new Indumentaria(Equipos.ListaMedias[Media], Equipos.ListaPantalones[Pantalon], Equipos.ListaRemeras[Remera]);
            bool pudoIngresar = Equipos.IngresarIndumentaria(Equipos.ListaEquipos[Equipo], unaIndumentaria);
            if (pudoIngresar == false){
                ViewBag.ListaEquipos = Equipos.ListaEquipos;
                ViewBag.ListaMedias = Equipos.ListaMedias;
                ViewBag.ListaPantalones = Equipos.ListaPantalones;
                ViewBag.ListaRemeras = Equipos.ListaRemeras;
                ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
                return View("Index");
            }
            else
            {
                ViewBag.Error = "Error";
                return View("SelectIndumentaria");
            }
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
