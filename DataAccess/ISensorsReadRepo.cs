using ServerApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerApi.Data 
{
    public interface ISensorsReadRepo
    {
        Task<List<SensorsReadingEntity>> GetSensorReadingEntities();
        Task<SensorsReadingEntity> GetSensorReadingEntityById(int id);
        Task CreateSensorsReadEntity(SensorsReadingEntity sensorReads);
    }

}