using Microsoft.EntityFrameworkCore;
using PrzelicznikMVVM.BazaDanych.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzelicznikMVVM.BazaDanych.Context
{
    class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=PrzelicznikMVVM.db");
            base.OnConfiguring(optionsBuilder);
        }
            public DbSet<Jednostki> Jednostki { get; set; }
            public DbSet<PrzelicznikJednostek> PrzelicznikJednostek { get; set; }
            public DbSet<Rodzaj> RodzajJednostki { get; set; }
    }
}
