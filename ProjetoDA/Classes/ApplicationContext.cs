using ProjetoDA.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Microsoft.EntityFrameworkCore;

namespace ProjetoDA
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Sala> Salas { get; set; }
<<<<<<< HEAD
        public DbSet<Sessões> Sessões { get; set; }
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Set the database provider and connection string
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
=======
        //public DbSet<Filmes> Filmes { get; set; }
        
>>>>>>> b28ecfefcbe8599c8ee6c5d3faec9b012314ad8a
    }


}

