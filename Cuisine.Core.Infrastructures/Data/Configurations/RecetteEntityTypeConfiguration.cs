using Cuisine.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine.Core.Infrastructures.Data.Configurations
{
    public class RecetteEntityTypeConfiguration : IEntityTypeConfiguration<Recette>
    {
        public void Configure(EntityTypeBuilder<Recette> builder)
        {
            builder.ToTable("Recette");
        }
    }
}
