

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServerApi.Models;

namespace ServerApi.Data
{
public class SensorsReadRepo : ISensorsReadRepo 
    {
    private readonly DbStorageContext context;

    public SensorsReadRepo (DbStorageContext context)
    {
        this.context = context;
    }

        public Task CreateSensorsReadEntity(SensorsReadingEntity sensorReads)
        {
            if(sensorReads == null)
            {
                throw new ArgumentNullException(nameof(sensorReads));
            }
            sensorReads.ReadTimeMilis = (long) DateTime.Now
                                        .ToUniversalTime()
                                        .Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
                                        .TotalMilliseconds;
            context.SensorsReadEntities.Add(sensorReads);
            return context.SaveChangesAsync();
        }

        public Task<List<SensorsReadingEntity>> GetSensorReadingEntities()
        {
            return context.SensorsReadEntities.ToListAsync();
        }

        public Task<SensorsReadingEntity> GetSensorReadingEntityById(int id)
        {
            return context.SensorsReadEntities.FirstOrDefaultAsync(e => e.Id == id);
        }
    }

}