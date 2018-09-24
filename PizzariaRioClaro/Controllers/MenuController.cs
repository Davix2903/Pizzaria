using PizzariaRioClaro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzariaRioClaro.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            ViewBag.Sabores = dao.Lista();
            return View();
        }
    }
}