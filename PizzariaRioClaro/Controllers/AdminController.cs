using PizzariaRioClaro.Filters;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzariaRioClaro.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var pessoa = (Pessoa)Session["PessoaLogada"];

            if (pessoa.TipoDePessoa == 'A' || pessoa.TipoDePessoa == 'F')
            {
                return View();
            }

            return RedirectToAction("Index", "Home");
        }


    }
}