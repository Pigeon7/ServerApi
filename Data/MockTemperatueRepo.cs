using ServerApi.Models;
using System;
using System.Collections.Generic;

namespace ServerApi.Data
{
    public class MockTemperatureRepo : ISensorsReadRepo
    {
        public void CreateSensorsReadEntity(SensorsReadEntity sensorReads)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SensorsReadEntity> GetSensorReadingEntities() => new List<SensorsReadEntity>
            {
                new SensorsReadEntity
                {
                    Id = 1,
                    TemperatureValue = 00.12F,
                    HumidityValue = 19,
                    ReadTimeMilis = DateTime.Now.Millisecond
                },
                new SensorsReadEntity
                {
                    Id = 2,
                    TemperatureValue = 17.56F,
                    HumidityValue = 17,
                    ReadTimeMilis = DateTime.Now.Millisecond
                },
                new SensorsReadEntity
                {
                    Id = 3,
                    TemperatureValue = 44.44F,
                    HumidityValue = 44,
                    ReadTimeMilis = DateTime.Now.Millisecond
                }
            };


        public SensorsReadEntity GetSensorReadingEntityById(int id)
        {
            return new SensorsReadEntity
            {
                Id = id,
                TemperatureValue = 17.56F,
                HumidityValue = 45,
                ReadTimeMilis = DateTime.Now.Millisecond
            };
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

}