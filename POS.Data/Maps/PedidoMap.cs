using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Maps
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TotalProducto)
                   .IsRequired();

            builder.Property(x => x.Total)
                   .HasColumnType("decimal(8,2)");

            builder.HasOne(x => x.ClienteDireccion)
                   .WithMany()
                   .HasForeignKey(x => x.ClienteDireccionId);

            builder.HasOne(x => x.Cliente)
                   .WithMany()
                   .HasForeignKey(x => x.ClienteId);

            builder.HasMany(x => x.DetallePedidos)
                   .WithOne(x => x.Pedido)
                   .HasForeignKey(x => x.PedidoId);
        }
    }
}
