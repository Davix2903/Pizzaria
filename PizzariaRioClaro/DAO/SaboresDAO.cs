using Microsoft.EntityFrameworkCore;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.DAO
{
    public class SaboresDAO
    {
        public void Adiciona(Sabores sabores)
        {
            using (var context = new PizzariaContext())
            {
                context.Sabores.Add(sabores);
                context.SaveChanges();
            }
        }

        public IList<Sabores> Lista()
        {
            using (var contexto = new PizzariaContext())
            {
                return contexto.Sabores.ToList();
            }
        }

        public Sabores BuscaPorId(int id)
        {
            using (var contexto = new PizzariaContext())
            {
                return contexto.Sabores.Find(id);
            }
        }

        public void Atualiza(Sabores sabores)
        {
            using (var contexto = new PizzariaContext())
            {
                contexto.Entry(sabores).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}