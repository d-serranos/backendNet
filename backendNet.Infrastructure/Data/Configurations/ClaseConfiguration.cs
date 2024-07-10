using backendNet.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backendNet.Infrastructure.Data.Configurations
{
    public class ClaseConfiguration : IEntityTypeConfiguration<Clase>
    {
        public void Configure(EntityTypeBuilder<Clase> construir)
        {
            construir
                .HasKey(x => x.Id);
            construir
                .Property(x => x.Id)
                .UseIdentityColumn();
            construir
                .Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(255);
            construir
                .Property(x => x.Capacidad)
                .IsRequired();
            construir
                .HasOne(x => x.Escuela)
                .WithMany( y => y.Clases)
                .HasForeignKey(x => x.EscuelaId);
            construir
                .ToTable("Clases");

        }
    }
}
