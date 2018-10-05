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
        public void AumentaQtd(int id, char tipo)
        {
            switch (tipo)
            {
                case 'D':
                    Itens.FirstOrDefault(x => x.SaboresDoceId == id).Quantidade++;
                    break;
                case 'R':
                    Itens.FirstOrDefault(x => x.RefrigeranteId == id).Quantidade++;
                    break;
                default:
                    Itens.FirstOrDefault(x => x.SaboresId == id).Quantidade++;
                    break;
            }
        }

        public void DiminuiQtd(int id, char tipo)
        {
            switch (tipo)
            {
                case 'D':
                    Itens.FirstOrDefault(x => x.SaboresDoceId == id).Quantidade--;
                    break;
                case 'R':
                    Itens.FirstOrDefault(x => x.RefrigeranteId == id).Quantidade--;
                    break;
                default:
                    Itens.FirstOrDefault(x => x.SaboresId == id).Quantidade--;
                    break;
            }
        }

        public void RemoveItem(int id, char tipo)
        {
            switch (tipo)
            {
                case 'D':
                    Itens.Remove(Itens.FirstOrDefault(x => x.SaboresDoceId == id));
                    break;
                case 'R':
                    Itens.Remove(Itens.FirstOrDefault(x => x.RefrigeranteId == id));
                    break;
                default:
                    Itens.Remove(Itens.FirstOrDefault(x => x.SaboresId == id));
                    break;
            }
        }
    }
}