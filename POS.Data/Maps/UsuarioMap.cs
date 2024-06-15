using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Data.Entities;

namespace POS.Data.Maps
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nombre)
                   .IsRequired()
                   .HasMaxLength(250);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(60);

            builder.Property(u => u.usuario)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(u => u.Salt)
                   .IsRequired()
                   .HasMaxLength(32);

            builder.Property(u => u.Clave)
                   .IsRequired()
                   .HasMaxLength(64);
        }
    }
}
