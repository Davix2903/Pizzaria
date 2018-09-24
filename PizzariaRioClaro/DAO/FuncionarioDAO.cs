//using Microsoft.EntityFrameworkCore;
//using PizzariaRioClaro.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace PizzariaRioClaro.DAO
//{
//    public class FuncionarioDAO
//    {
//        public void Adiciona(Funcionario funcionario)
//        {
//            using (var context = new PizzariaContext())
//            {
//                context.Funcionarios.Add(funcionario);
//                context.SaveChanges();
//            }
//        }

//        public IList<Funcionario> ListaFuncionarios(Funcionario funcionario)
//        {
//            using (var contexto = new PizzariaContext())
//            {
//                return contexto.Funcionarios.ToList();
//            }
//        }

//        public Funcionario BuscaPorId(int id)
//        {
//            using (var contexto = new PizzariaContext())
//            {
//                return contexto.Funcionario.Find(id);
//            }
//        }

//        public void Atualiza(Funcionario funcionario)
//        {
//            using (var contexto = new PizzariaContext())
//            {
//                contexto.Entry(funcionario).State = EntityState.Modified;
//                contexto.SaveChanges();
//            }
//        }

//        public Funcionario Busca(string login, string senha)
//        {
//            using (var contexto = new PizzariaContext())
//            {
//                return contexto.Funcionarios.Include(f => f.Pessoa).FirstOrDefault(f => f.NomeUsuario == login && f.Senha == senha);
//            }
//        }
//    }
//}