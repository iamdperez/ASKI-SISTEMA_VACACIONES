﻿using ASKI_VACACIONES.Models;
using ASKI_VACACIONES.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASKI_VACACIONES.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            if (Session["User"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }
        [HttpPost]
        public ActionResult Index(UsuariosModel model)
        {
            if (Session["User"] != null)
            {
                if (ModelState.IsValid)
                {
            Service1Client client = new Service1Client();
            client.addUsuario(model.talento_humano, model.email, model.primer_nombre,model.segundo_nombre,model.primer_apellido,model.segundo_apellido,model.fecha_ingreso,model.password);
            client.Close();
                }
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult Edit()
        {
            if (Session["User"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }
        [HttpPost]
        public ActionResult Edit(UsuariosModel model, string submitButton)
        {
            Service1Client client = new Service1Client();
            switch (submitButton)
            {
                case "Buscar":
                    var hola = client.getUsuario(model.talento_humano);
                    if (hola != null)
                    {
                        ViewBag.email = hola.email;
                        ViewBag.talentoHumano = hola.talento_humano;
                        ViewBag.primerNombre = hola.primer_nombre;
                        ViewBag.segundoNombre = hola.segundo_nombre;
                        ViewBag.primerApellido = hola.primer_apellido;
                        ViewBag.segundoNombre = hola.segundo_apellido;
                        ViewBag.fechaIngreso = hola.fecha_ingreso;                       
                    }
                    // client.Close();
                    return View();
                case "Modificar":
                    if (Session["User"] != null)
                    {
                        client.editUsuario(model.talento_humano, model.email,model.primer_nombre,model.segundo_nombre,model.primer_apellido, model.segundo_apellido,model.fecha_ingreso);
                        client.Close();
                    }
                    return View();
                default:
                    return RedirectToAction("Login");
            }
        }
        public ActionResult Delete()
        {
            if (Session["User"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }
    }
}