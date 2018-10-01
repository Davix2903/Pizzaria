using Microsoft.EntityFrameworkCore;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.DAO
{
    public class PessoaDAO
    {
        public void Adiciona(Pessoa pessoa)
        {
            using (var context = new PizzariaContext())
            {
                context.Pessoas.Add(pessoa);
                context.SaveChanges();
            }
        }

        public IList<Pessoa> Lista()
        {
            using (var contexto = new PizzariaContext())
            {
                return contexto.Pessoas.Include("Pessoa").ToList();
            }
        }

        public Pessoa BuscaPorId(int id)
        {
            using (var contexto = new PizzariaContext())
            {
                return contexto.Pessoas.Find(id);
            }
        }

        public void Atualiza(Pessoa pessoa)
        {
            using (var contexto = new PizzariaContext())
            {
                contexto.Entry(pessoa).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public Pessoa Busca(string login, string senha)
        {
            using (var contexto = new PizzariaContext())
            {
                return contexto.Pessoas.Where(p => p.Email == login && p.Senha == senha).FirstOrDefault();
            }
        }
    }
}