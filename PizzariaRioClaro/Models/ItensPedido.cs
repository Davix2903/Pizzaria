﻿
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

        public Refrigerante Refrigerante { get; set; }
        public int? RefrigeranteId { get; set; }

        public Sabores Sabores { get; set; }
        public int? SaboresId { get; set; }

        public SaboresDoce SaboresDoce { get; set; }
        public int? SaboresDoceId { get; set; }

        public int Quantidade { get; set; }
    }
}