using System;
using ServerApi.Dtos;
using ServerApi.Models;

namespace ServerApi.Mappers 
{
    public class IncomingDataMapper 
    {
        public SensorsReadEntity MapIncomingData (CreateSensorReadDto incomingEntity)
        {
            var result = new SensorsReadEntity();
            result.HumidityValue = incomingEntity.HumidityValue;
            result.TemperatureValue = incomingEntity.TemperatureValue;
            result.ReadTimeMilis = DateTime.Now.Millisecond;
            return result;
        }
    }


}