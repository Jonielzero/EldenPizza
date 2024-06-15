using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Data.Entities;

namespace POS.Data.Maps
{
    public class TipoProductoMap : IEntityTypeConfiguration<TipoProducto>
    {
        public void Configure(EntityTypeBuilder<TipoProducto> builder)
        {
            builder.ToTable("TipoProducto");
            builder.HasKey(x => x.Id);
        }
    }
}
