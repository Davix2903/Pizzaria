﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public Pessoa Usuario { get; set; }
    }
}