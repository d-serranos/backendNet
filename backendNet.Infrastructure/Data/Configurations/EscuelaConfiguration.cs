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
    public class EscuelaConfiguration : IEntityTypeConfiguration<Escuela>
    {
        public void Configure(EntityTypeBuilder<Escuela> construir)
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
                .Property(x => x.Direccion)
                .IsRequired()
                .HasMaxLength(255);
            construir
                .ToTable("Escuelas");
        }
    }
}
