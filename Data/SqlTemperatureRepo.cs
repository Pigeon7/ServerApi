

using System;
using System.Collections.Generic;
using System.Linq;
using ServerApi.Models;

namespace ServerApi.Data
{
public class SqlTemperatureRepo : ISensorsReadRepo 
    {
    private readonly RaspStorageContext _context;

    public SqlTemperatureRepo (RaspStorageContext context)
    {
        _context = context;
    }

        public void CreateSensorsReadEntity(SensorsReadEntity sensorReads)
        {
            if(sensorReads == null)
            {
                throw new ArgumentNullException(nameof(sensorReads));
            }
            sensorReads.ReadTimeMilis = (long) DateTime.Now
                                        .ToUniversalTime()
                                        .Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
                                        .TotalMilliseconds;
            _context.SensorsReadEntities.Add(sensorReads);
        }

        public IEnumerable<SensorsReadEntity> GetSensorReadingEntities()
        {
            return _context.SensorsReadEntities.ToList();
        }

        public SensorsReadEntity GetSensorReadingEntityById(int id)
        {
            return _context.SensorsReadEntities.FirstOrDefault(e => e.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

}