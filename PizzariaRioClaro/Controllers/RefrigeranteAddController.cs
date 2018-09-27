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
    [AutorizacaoFilter]
    public class RefrigeranteAddController : Controller
    {
        // GET: Refrigerante
        public ActionResult Index()
        {
            ViewBag.Refrigerante = new Refrigerante();
            return View();
        }
        public ActionResult Adiciona(Refrigerante refrigerante)
        {
            RefrigeranteDAO dao = new RefrigeranteDAO();
            if (refrigerante != null)
            {
                dao.Adiciona(refrigerante);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}