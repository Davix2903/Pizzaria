using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.DAO
{
    public class PedidoDAO
    {
        public Pedido Teste()
        {
            using (var contexto = new PizzariaContext())
            {
                //var pedido = Session["usuarioLogado"] as Pedido;
                var testeP2 = contexto.Pedidos.FirstOrDefault(p => p.Status == "Pendente" && p.Id == 1); //pedido
                var testePs = contexto.itensPedidos.Where(p => p.Pedido == testeP2).ToArray(); //itens do pedido
                foreach (var item in testePs)
                {
                    Console.WriteLine(Convert.ToString(testePs), testeP2);
                }
            }
            return null;
        }

        private int usuarioLogado()
        {
            throw new NotImplementedException();
        }
    }
}