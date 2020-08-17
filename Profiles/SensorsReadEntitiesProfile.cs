using AutoMapper;
using ServerApi.Dtos;
using ServerApi.Models;

namespace ServerApi.Profiles 
{
    public class SensorsReadEntitiesProfile : Profile
    {
        public SensorsReadEntitiesProfile() 
        {
            CreateMap<SensorsReadEntity, TempReadDto>();
            CreateMap<SensorsReadEntity, HumidReadDto>();
            CreateMap<CreateSensorReadDto, SensorsReadEntity>();
        } 
    }

}