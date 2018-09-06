using PizzariaRioClaro.DAO;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzariaRioClaro.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Autentica(string login, string senha)
        {
            PessoaDAO dao = new PessoaDAO();
            Pessoa pessoa = dao.Busca(login, senha);
            if (pessoa != null)
            {
                Session["PessoaLogada"] = pessoa;
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult AdicionaPessoa(Pessoa pessoa, string novamenteASenha)
        {
            PessoaDAO dao = new PessoaDAO();
            pessoa.TipoDePessoa = 'F';
            if (pessoa.Senha == novamenteASenha)
            {
                dao.Adiciona(pessoa);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Funcionario = pessoa;
                return View("Cadastro");
            }
        }
    }
}