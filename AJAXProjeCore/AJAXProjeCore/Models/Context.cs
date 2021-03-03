using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJAXProjeCore.Models
{
    public class Context
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilders)
        {
            //optionsBuilders.UseSqlServer("server="YOURSERVER"; database="YOURDB"; integrated security=true;");
        }

        public DbSet<Birim> Birims { get; set; }
    }
}
