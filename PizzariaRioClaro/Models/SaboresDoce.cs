using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.Models
{
    public class SaboresDoce
    {
        public int Id { get; set; }

        [Required]
        public string Sabor { get; set; }

        [Required]
        public string Ingredientes { get; set; }

        [Required]
        public double Preco { get; set; }
    }
}