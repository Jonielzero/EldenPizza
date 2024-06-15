using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Data.Entities;

namespace POS.Data.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Direcciones).WithOne(x => x.Cliente).HasForeignKey(x => x.ClienteId);
        }
    }
}
