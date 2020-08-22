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
    public class AnuncioController : Controller
    {
        public IActionResult Cadastro()
        {
            /*if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }*/
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Anuncio novoAnuncio)
        {
            AnuncioBanco anun =  new AnuncioBanco();
            anun.Insert(novoAnuncio);
            ViewBag.Mensagem = "Cadastro concluído com sucesso!";
            return View();
        }
        public IActionResult Lista()
        {
            /*if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }*/
            AnuncioBanco anun = new AnuncioBanco();
            List<Anuncio> lista = anun.Query();
            return View(lista);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Usuario");
        }
        /*public IActionResult Vitrine()
        {
            PacoteBanco pack = new PacoteBanco();
            List<Pacote> lista = pack.Query();
            return View(lista);
        }*/
    }
}