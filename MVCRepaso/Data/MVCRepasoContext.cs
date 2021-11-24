using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCRepaso.Models;

namespace MVCRepaso.Data
{
    public class MVCRepasoContext : DbContext
    {
        public MVCRepasoContext (DbContextOptions<MVCRepasoContext> options)
            : base(options)
        {
        }

        public DbSet<MVCRepaso.Models.Usuario> Usuario { get; set; }

        public DbSet<MVCRepaso.Models.Mascota> Mascota { get; set; }
    }
}
