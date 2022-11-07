using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace Cuisine.Core.Infrastructures.Data
{
    public class CuisineContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            

            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "Setting", "appsetting.json"));
            IConfigurationRoot configurationRoot = configurationBuilder.Build();
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();


            builder.UseSqlServer(configurationRoot.GetConnectionString("DefaultConnection"));
            DatabaseContext context = new DatabaseContext(builder.Options);
            return context;
        }
    }
}
