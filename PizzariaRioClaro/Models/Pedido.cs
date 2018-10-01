using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }

        public Pessoa Usuario { get; set; }

        public IList<ItensPedido> Itens { get; set; }

        public Pedido()
        {
            Itens = new List<ItensPedido>();
        }

        public void AdicionaItem(int id, char tipo)
        {
            switch (tipo)
            {
                case 'D':
                    Itens.Add(new ItensPedido() { SaboresDoceId = id, Quantidade = 1 });
                    break;
                case 'R':
                    Itens.Add(new ItensPedido() { RefrigeranteId = id, Quantidade = 1 });
                    break;
                default: 
                    Itens.Add(new ItensPedido() { SaboresId = id, Quantidade = 1 });
                    break;
            }
        }
    }
}