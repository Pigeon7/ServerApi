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
    public class IncomingDataService : IDataIncomingService
    {
        private readonly ISensorsReadRepo repo;
        private readonly IMapper mapper;

        public IncomingDataService(ISensorsReadRepo repo, IMapper mapper) 
        {
            this.repo= repo;
            this.mapper = mapper;
        }

        public void GetDataAndSave(CreateSensorReadDto incomingEntity)
        {
            var model = mapper.Map<SensorsReadEntity>(incomingEntity);
            repo.CreateSensorsReadEntity(model);
            repo.SaveChanges();
        }
    }
}
