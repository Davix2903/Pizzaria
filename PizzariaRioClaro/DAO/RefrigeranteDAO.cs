using Microsoft.EntityFrameworkCore;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.DAO
{
    public class RefrigeranteDAO
    {
        public void Adiciona(Refrigerante refrigerante)
        {
            using (var context = new PizzariaContext())
            {
                context.Refrigerantes.Add(refrigerante);
                context.SaveChanges();
            }
        }

        public IList<Refrigerante> Lista()
        {
            using (var contexto = new PizzariaContext())
            {
                return contexto.Refrigerantes.ToList();
            }
        }

        public Refrigerante BuscaPorId(int id)
        {
            using (var contexto = new PizzariaContext())
            {
                return contexto.Refrigerantes.Find(id);
            }
        }

        public void Atualiza(Refrigerante refrigerante)
        {
            using (var contexto = new PizzariaContext())
            {
                contexto.Entry(refrigerante).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}