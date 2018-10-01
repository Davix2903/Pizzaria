using Microsoft.EntityFrameworkCore;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaRioClaro.DAO
{
    public class PizzariaContext : DbContext
    {
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Sabores> Sabores { get; set; }
        public DbSet<Refrigerante> Refrigerantes { get; set; }
        public DbSet<SaboresDoce> SaboresDoce { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItensPedido> itensPedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PizzariaDB;Trusted_Connection=true;");
        }
    }
}