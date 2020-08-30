using Microsoft.EntityFrameworkCore;
using ServerApi.Models;

namespace ServerApi.Data

{
    public class DbStorageContext : DbContext 
    {
        public DbStorageContext(DbContextOptions<DbStorageContext> opt) : base (opt)
        {


        }

        public DbSet<SensorsReadingEntity> SensorsReadings { get; set; }

    } 


}