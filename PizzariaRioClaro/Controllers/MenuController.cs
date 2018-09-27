using PizzariaRioClaro.DAO;
using PizzariaRioClaro.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzariaRioClaro.Controllers
{
    [AutorizacaoFilter]
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            SaboresDAO dao = new SaboresDAO();
            ViewBag.Sabores = dao.Lista();
            RefrigeranteDAO rdao = new RefrigeranteDAO();
            ViewBag.Refrigerantes = rdao.Lista();
            return View();
        }
    }
}