
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.Models
{
    public class ItensPedido
    {
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
    }
}