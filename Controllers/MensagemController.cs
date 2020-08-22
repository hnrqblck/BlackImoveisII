using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlackImoveisII.Models;
using Microsoft.AspNetCore.Http;

namespace BlackImoveisII.Controllers
{
    public class MensagemController : Controller
    {
        public IActionResult FaleConosco()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FaleConosco(Mensagem novaMensagem)
        {
            MensagemBanco mens =  new MensagemBanco();
            mens.Insert(novaMensagem);
            ViewBag.Mensagem = "Mensagem enviada com sucesso!";
            return View();
        }
        public IActionResult Lista()
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            MensagemBanco mens = new MensagemBanco();
            List<Mensagem> lista = mens.Query();
            return View(lista);
        }
        
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Usuario");
        }
    }
}