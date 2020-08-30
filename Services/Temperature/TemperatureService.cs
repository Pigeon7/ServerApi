using AutoMapper;
using ServerApi.Data;
using ServerApi.Dtos;
using ServerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Services.Temperature
{
    public class TemperatureService : ITemperatureService
    {
        private readonly ISensorsReadRepo sensorsReadRepo;
        private readonly IMapper mapper;

        public TemperatureService(ISensorsReadRepo sensorsReadRepo, IMapper mapper)
        {
            this.sensorsReadRepo = sensorsReadRepo;
            this.mapper = mapper;
        }
        public async Task<TemperatureResponseDto> ReadAllTemperatures()
        {
            var list = await sensorsReadRepo.GetSensorReadingEntities();
            var result = new TemperatureResponseDto
            {
                TemperaturesList = mapper.Map<List<SensorsReadingEntity>, List<TemperatureResponseItemDto>>(list)
            };
            return result;
        }

        public async Task<TemperatureResponseItemDto> ReadTemperatureById(int id)
        {
            return mapper.Map<SensorsReadingEntity, TemperatureResponseItemDto>(await sensorsReadRepo.GetSensorReadingEntityById(id));
        }
    }
}
