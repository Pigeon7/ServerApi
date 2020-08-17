using ServerApi.Models;
using System.Collections.Generic;

namespace ServerApi.Data 
{
    public interface ISensorsReadRepo
    {
        IEnumerable<SensorsReadEntity> GetSensorReadingEntities();
        SensorsReadEntity GetSensorReadingEntityById(int id);

        void CreateSensorsReadEntity(SensorsReadEntity sensorReads);
        void SaveChanges();
    }

}