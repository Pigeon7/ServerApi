using Microsoft.EntityFrameworkCore;
using ServerApi.Models;

namespace ServerApi.Data

{
    public class RaspStorageContext : DbContext 
    {
        public RaspStorageContext(DbContextOptions<RaspStorageContext> opt) : base (opt)
        {


        }

        public DbSet<SensorsReadEntity> SensorsReadEntities { get; set; }

    } 


}