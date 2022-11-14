using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using comp367lab3mvc.Models;

namespace comp367lab3mvc.Data
{
    public class comp367lab3mvcContext : DbContext
    {
        public comp367lab3mvcContext (DbContextOptions<comp367lab3mvcContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
