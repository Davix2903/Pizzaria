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
    public class CarrinhoController : Controller
    {
        // GET: Carrinho
        public ActionResult Index()
        {
            var carrinho = Session["Carrinho"] as Pedido;
            if (carrinho == null)
            {
                carrinho = new Pedido();
                carrinho.Status = "Pendente";
                Session["Carrinho"] = carrinho;
            }

            var saborDAO = new SaboresDAO();
            var saborDoceDAO = new SaboresDoceDAO();
            var refriDAO = new RefrigeranteDAO();

            foreach (var item in carrinho.Itens)
            {
                if (item.RefrigeranteId.HasValue)
                    item.Refrigerante = refriDAO.BuscaPorId((int)item.RefrigeranteId);
                if (item.SaboresDoceId.HasValue)
                    item.SaboresDoce = saborDoceDAO.BuscaPorId((int)item.SaboresDoceId);
                if (item.SaboresId.HasValue)
                    item.Sabores = saborDAO.BuscaPorId((int)item.SaboresId);
            }
            
            return View(carrinho);
        }

        public JsonResult Adiciona(int id, char tipo)
        {
            var carrinho = Session["Carrinho"] as Pedido;
            if (carrinho == null)
            {
                carrinho = new Pedido();
                carrinho.Status = "Pendente";
                Session["Carrinho"] = carrinho;
            }

            var jaExiste = false;

            switch (tipo)
            {
                case 'R':
                    jaExiste = carrinho.Itens.Where(i => i.RefrigeranteId == id).ToList().Count > 0;
                    break;
                case 'D':
                    jaExiste = carrinho.Itens.Where(i => i.SaboresDoceId == id).ToList().Count > 0;
                    break;
                default:
                    jaExiste = carrinho.Itens.Where(i => i.SaboresId == id).ToList().Count > 0;
                    break;
            }

            if (jaExiste) return Json(new { adicionou = false, msg = "Item já presente no pedido" }, JsonRequestBehavior.AllowGet);

            carrinho.AdicionaItem(id, tipo);

            return Json(new { adicionou = true }, JsonRequestBehavior.AllowGet);
        }
    }
}