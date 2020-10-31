using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TPClass;

namespace TPBaseDeDatos
{
    class DBContext:DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDBCF;Trusted_Connection=True;");
        }
    }
}
