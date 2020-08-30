using ServerApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Services
{
    public interface ISensorsReadingService
    {
        Task ReceiveSensorData(CreateSensorReadDto sensorsDataDto);
    }
}
