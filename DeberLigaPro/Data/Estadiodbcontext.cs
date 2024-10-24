using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeberLigaPro.Models;

    public class Estadiodbcontext : DbContext
    {
        public Estadiodbcontext (DbContextOptions<Estadiodbcontext> options)
            : base(options)
        {
        }

        public DbSet<DeberLigaPro.Models.Estadio> Estadio { get; set; } = default!;
    }
