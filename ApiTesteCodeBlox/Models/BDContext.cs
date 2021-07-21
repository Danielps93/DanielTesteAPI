using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCodeBlox.Models
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options) : base(options){ }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Produto>().HasKey(x => x.IdProduto);
            base.OnModelCreating(model);
        }
    }

    
}
