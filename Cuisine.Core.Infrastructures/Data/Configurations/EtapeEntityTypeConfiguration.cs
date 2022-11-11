using Cuisine.Core.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine.Core.Infrastructures.Data.Configurations
{
    public class EtapeEntityTypeConfiguration: IEntityTypeConfiguration<Etape>
    {
        public void Configure(EntityTypeBuilder<Etape> builder)
        {
            builder.ToTable("Etape");
            builder.HasKey(p => p.Id);

        }
    }
}
