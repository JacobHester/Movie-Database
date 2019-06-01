using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieDatabase.Models
{
    public class MovieDatabaseContext : DbContext
    {
        public MovieDatabaseContext (DbContextOptions<MovieDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<MovieDatabase.Models.Movie> Movie { get; set; }
    }
}
