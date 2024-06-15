using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using POS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Maps
{
    public class DetallePedidoMap : IEntityTypeConfiguration<DetallePedido>
    {
        public void Configure(EntityTypeBuilder<DetallePedido> builder)
        {
            builder.ToTable("DetallePedido");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Cantidad)
                   .IsRequired();

            builder.Property(x => x.Precio)
                   .HasColumnType("decimal(8,2)");

            builder.Property(x => x.Total)
                   .HasColumnType("decimal(8,2)");

            builder.HasOne(x => x.Pedido)
                   .WithMany(p => p.DetallePedidos)
                   .HasForeignKey(x => x.PedidoId);

            builder.HasOne(x => x.Producto)
                   .WithMany()
                   .HasForeignKey(x => x.ProductoId);
        }
    }
}
