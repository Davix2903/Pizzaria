using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.Models
{
    public class Refrigerante
    {
        public int Id { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Tamanho { get; set; }
    }
}