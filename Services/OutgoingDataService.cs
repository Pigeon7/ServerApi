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
    public class OutgoingDataService : IDataOutgoingService
    {
        private readonly ISensorsReadRepo repo;
        private readonly IMapper mapper;

        public OutgoingDataService(ISensorsReadRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public IEnumerable<HumidReadDto> ReadHumidities()
        {
            var list = repo.GetSensorReadingEntities();
            return mapper.Map<IEnumerable<HumidReadDto>>(list);
        }

        public HumidReadDto ReadHumidityById(int id)
        {
            var item = repo.GetSensorReadingEntityById(id);
            return mapper.Map<HumidReadDto>(item);
        }

        public SensorsReadEntity ReadSensorEntityById(int id)
        {
            var sensorsReadEntity = repo.GetSensorReadingEntityById(id);
            return mapper.Map<SensorsReadEntity>(sensorsReadEntity);
        }

        public TempReadDto ReadTemperatureById(int id)
        {
            var item = repo.GetSensorReadingEntityById(id);
            return mapper.Map<TempReadDto>(item);
        }

        public IEnumerable<TempReadDto> ReadTemperatures()
        {
            var list = repo.GetSensorReadingEntities();
            return mapper.Map<IEnumerable<TempReadDto>>(list);
        }
    }
}
