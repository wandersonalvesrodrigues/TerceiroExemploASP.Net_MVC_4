using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TerceiroExemploMVC.Models;

namespace TerceiroExemploMVC.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            /*if (string.IsNullOrEmpty(pessoa.Nome)) 
            {
                ModelState.AddModelError("nome", "Nome é obrigatório");
            }

            if (string.IsNullOrEmpty(pessoa.Senha)) 
            {
                ModelState.AddModelError("senha", "A senha é obrigatória");
            }

            if(!string.Equals(pessoa.Senha,pessoa.ConfirmarSenha))
            {
                ModelState.AddModelError("","As senhas não conferem");
            }*/

            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoNomes = new Collection<string> 
            {
                "João",
                "Maria"
            };

            return Json(bancoNomes.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}
