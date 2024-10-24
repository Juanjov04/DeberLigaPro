using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeberLigaPro.Models;

    public class Jugadorbdcontext : DbContext
    {
        public Jugadorbdcontext (DbContextOptions<Jugadorbdcontext> options)
            : base(options)
        {
        }

        public DbSet<DeberLigaPro.Models.Jugador> Jugador { get; set; } = default!;
    }
