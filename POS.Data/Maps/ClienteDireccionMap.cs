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
    public class ClienteDireccionMap : IEntityTypeConfiguration<ClienteDireccion>
    {
        public void Configure(EntityTypeBuilder<ClienteDireccion> builder)
        {
            builder.ToTable("ClienteDireccion");
            builder.HasKey(x => x.Id);

            
        }
    }
}
