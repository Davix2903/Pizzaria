using PizzariaRioClaro.DAO;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzariaRioClaro.Controllers
{
    public class SaboresAddController : Controller
    {
        // GET: ProdutoAdd
        public ActionResult Index()
        {
            ViewBag.Sabores = new Sabores();
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Sabores sabores)
        {
            ProdutoDAO dao = new ProdutoDAO();
            if (sabores != null)
            {
                dao.Adiciona(sabores);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }


        }
    }
}