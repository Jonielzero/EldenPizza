using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Data.Entities;

namespace POS.Data.Maps
{
    public class ProductoMap : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.TipoProducto).WithMany(x => x.Productos).HasForeignKey(x => x.TipoProductoId);
        }
    }
}
