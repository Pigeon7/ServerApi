using AutoMapper;
using ServerApi.Data;
using ServerApi.Dtos;
using ServerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Services
{
    public class SensorsReadingService : ISensorsReadingService
    {
        private readonly ISensorsReadRepo sensorsReadingRepo;
        private readonly IMapper mapper;

        public SensorsReadingService(ISensorsReadRepo sensorsReadRepo, IMapper mapper)
        {
            sensorsReadingRepo = sensorsReadRepo;
            this.mapper = mapper;
        }

        public Task ReceiveSensorData(CreateSensorReadDto sensorsDataDto)
        {
             return sensorsReadingRepo.CreateSensorsReadEntity(mapper.Map<CreateSensorReadDto, SensorsReadingEntity>(sensorsDataDto));
        }

    }
}
