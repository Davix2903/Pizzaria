using Microsoft.EntityFrameworkCore;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.DAO
{
    public class SaboresDoceDAO
    {
        public void Adiciona(SaboresDoce saboresDoce)
        {
            using (var context = new PizzariaContext())
            {
                context.SaboresDoce.Add(saboresDoce);
                context.SaveChanges();
            }
        }

        public IList<SaboresDoce> Lista()
        {
            using (var contexto = new PizzariaContext())
            {
                return contexto.SaboresDoce.ToList();
            }
        }

        public SaboresDoce BuscaPorId(int id)
        {
            using (var contexto = new PizzariaContext())
            {
                return contexto.SaboresDoce.Find(id);
            }
        }

        public void Atualiza(SaboresDoce saboresDoce)
        {
            using (var contexto = new PizzariaContext())
            {
                contexto.Entry(saboresDoce).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}