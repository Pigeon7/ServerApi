using ServerApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Services.Humidity
{
    public interface IHumidityService
    {
        Task<HumidityResponseDto> ReadAllHumidities();
        Task<HumidityResponseItemDto> ReadHumidityById(int id);
    }
}
