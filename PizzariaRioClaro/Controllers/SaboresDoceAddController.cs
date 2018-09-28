using PizzariaRioClaro.DAO;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzariaRioClaro.Controllers
{
    public class SaboresDoceAddController : Controller
    {
        // GET: SaboresDoceAdd
        public ActionResult Index()
        {
            ViewBag.SaboresDoce = new SaboresDoce();       
            return View();
        }


        [HttpPost]
        public ActionResult Adiciona(SaboresDoce saboresDoce)
        {
            SaboresDoceDAO dao = new SaboresDoceDAO();
            if (saboresDoce != null)
            {
                dao.Adiciona(saboresDoce);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}