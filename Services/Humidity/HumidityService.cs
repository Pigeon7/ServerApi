using AutoMapper;
using ServerApi.Data;
using ServerApi.Dtos;
using ServerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Services.Humidity
{
    public class HumidityService : IHumidityService
    {
        private readonly ISensorsReadRepo sensorsReadRepo;
        private readonly IMapper mapper;

        public HumidityService(ISensorsReadRepo sensorsReadRepo, IMapper mapper)
        {
            this.sensorsReadRepo = sensorsReadRepo;
            this.mapper = mapper;
        }
        public async Task<HumidityResponseDto> ReadAllHumidities()
        {
            var list = await sensorsReadRepo.GetSensorReadingEntities();
            var result = new HumidityResponseDto
            {
                HumiditiesList = mapper.Map<List<SensorsReadingEntity>, List<HumidityResponseItemDto>>(list)
            };
            return result;
        }

        public async Task<HumidityResponseItemDto> ReadHumidityById(int id)
        {
            return mapper.Map<SensorsReadingEntity, HumidityResponseItemDto>(await sensorsReadRepo.GetSensorReadingEntityById(id));
        }
    }
}
