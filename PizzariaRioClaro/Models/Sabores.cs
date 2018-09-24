using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.Models
{
    public class Sabores
    {
        public int Id { get; set; }
        public string Sabor { get; set; }
        public char TipoPizza { get; set; }
        public string Ingredientes { get; set; }
        public double Preco { get; set; }
    }
}