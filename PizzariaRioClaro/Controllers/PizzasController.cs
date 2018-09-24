using PizzariaRioClaro.DAO;
using System.Web.Mvc;

namespace PizzariaRioClaro.Controllers
{
    public class PizzasController : Controller
    {
        // GET: Pizzas
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            ViewBag.Sabores = dao.Lista();
            return View();
        }
    }
}