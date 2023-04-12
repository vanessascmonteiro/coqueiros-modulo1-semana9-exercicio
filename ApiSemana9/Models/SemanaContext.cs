using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiSemana9.Models
{
    public class SemanaContext : DbContext
    {
        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
        {

        }

        public DbSet<SemanaModel> Semana {get; set;}

    }
}