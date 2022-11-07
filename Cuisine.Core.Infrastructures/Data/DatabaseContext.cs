using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuisine.Core.Photos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cuisine.Core.Infrastructures.Data.Configurations;

namespace Cuisine.Core.Infrastructures.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
         : base(options)
        {
        }

        public DatabaseContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PhotoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RecetteEntityTypeConfiguration());
        }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Recette> Recettes { get; set; }

    }
}
