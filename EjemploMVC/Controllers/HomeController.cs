﻿using Microsoft.AspNetCore.Mvc;
using EjemploMVC.Models;

namespace EjemploMVC.Controllers;
public class HomeController : Controller
{
    public IActionResult Index() => View();

    [HttpGet]
    public IActionResult InvitacionForm() => View();

    [HttpPost]
    public IActionResult InvitacionForm(Invitacion invitacion)
    {
        Repositorio.AgregarInvitacion(invitacion);
        return View("Gracias", invitacion);
    }
    public ViewResult ListaRespuestas() => View(Repositorio.InvitacionesAceptadas);
}