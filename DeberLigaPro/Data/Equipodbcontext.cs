using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeberLigaPro.Models;

    public class Equipodbcontext : DbContext
    {
        public Equipodbcontext (DbContextOptions<Equipodbcontext> options)
            : base(options)
        {
        }

        public DbSet<DeberLigaPro.Models.Equipo> Equipo { get; set; } = default!;
    }
