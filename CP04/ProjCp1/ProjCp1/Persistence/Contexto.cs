using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjCp1.Models;

namespace ProjCp1.Persistence

{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Roupas> Roupas { get; set; }

    }
}