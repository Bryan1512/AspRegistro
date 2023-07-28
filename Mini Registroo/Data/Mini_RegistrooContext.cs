using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mini_Registroo.Models;

namespace Mini_Registroo.Data
{
    public class Mini_RegistrooContext : DbContext
    {
        public Mini_RegistrooContext (DbContextOptions<Mini_RegistrooContext> options)
            : base(options)
        {
        }

        public DbSet<Mini_Registroo.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<Mini_Registroo.Models.Productos>? Productos { get; set; }

        public DbSet<Mini_Registroo.Models.Ventas>? Ventas { get; set; }
    }
}
