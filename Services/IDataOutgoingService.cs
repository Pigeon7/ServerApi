using ServerApi.Dtos;
using ServerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Services
{
    public interface IDataOutgoingService
    {
        SensorsReadEntity ReadSensorEntityById(int id);
        TempReadDto ReadTemperatureById(int id);
        IEnumerable<TempReadDto> ReadTemperatures();
        HumidReadDto ReadHumidityById(int id);
        IEnumerable<HumidReadDto> ReadHumidities();
    }
}
