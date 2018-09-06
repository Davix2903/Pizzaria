using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public char TipoDePessoa { get; set; }
        public string Senha { get; set; }
    }
}