using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ServerApi.Models;

namespace ServerApi.Data

{
    public class DbStorageContext : DbContext 
    {
        public DbStorageContext(DbContextOptions<DbStorageContext> opt) : base (opt)
        {


        }

        public DbSet<SensorsReadingEntity> SensorsReadEntities { get; set; }

    }

    public class DbFactory : IDesignTimeDbContextFactory<DbStorageContext>
    {
        public DbStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbStorageContext>();
            optionsBuilder.UseSqlServer("your connection string");

            return new DbStorageContext(optionsBuilder.Options);
        }
    }

}