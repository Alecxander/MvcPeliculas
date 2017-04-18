using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcPeliculas.Models
{
    public class MvcPeliculasContext : DbContext
    {
        public MvcPeliculasContext (DbContextOptions<MvcPeliculasContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPeliculas.Models.Movie> Movie { get; set; }
    }
}
