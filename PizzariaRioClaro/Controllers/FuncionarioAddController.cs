using PizzariaRioClaro.DAO;
using PizzariaRioClaro.Filters;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzariaRioClaro.Controllers
{
    public class FuncionarioAddController : Controller
    {
        // GET: FuncionarioAdd
        public ActionResult Index()
        {
            ViewBag.Pessoa = new Pessoa();
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Pessoa pessoa)
        {
            PessoaDAO dao = new PessoaDAO();
            if (pessoa != null)
            {
                dao.Adiciona(pessoa);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }

               
        }
    }
}