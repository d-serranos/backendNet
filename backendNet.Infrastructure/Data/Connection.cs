using backendNet.Core.Entities;
using backendNet.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backendNet.Infrastructure.Data
{
    public class Connection: DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Clase> Clases { get; set; }    
        public Connection(DbContextOptions<Connection> opc) : base(opc) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EscuelaConfiguration());
            builder.ApplyConfiguration(new ClaseConfiguration());
        }
    }
}
