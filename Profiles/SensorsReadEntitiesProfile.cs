using AutoMapper;
using ServerApi.Dtos;
using ServerApi.Models;

namespace ServerApi.Profiles 
{
    public class SensorsReadEntitiesProfile : Profile
    {
        public SensorsReadEntitiesProfile() 
        {
            CreateMap<SensorsReadingEntity, TemperatureResponseItemDto>();
            CreateMap<SensorsReadingEntity, HumidityResponseItemDto>();
            CreateMap<CreateSensorReadDto, SensorsReadingEntity>();
        } 
    }

}