using ServerApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Services.Temperature
{
    public interface ITemperatureService
    {
        Task<TemperatureResponseDto> ReadAllTemperatures();
        Task<TemperatureResponseItemDto> ReadTemperatureById(int id);
    }
}
