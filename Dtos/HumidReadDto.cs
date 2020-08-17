using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ServerApi.Dtos
{
    public class HumidReadDto
    {
        HumidReadDto()
        {}
        public int Id {get; set;}     

        public int HumidityValue {get; set;}     
        
        public long ReadTimeMilis {get; set;}     
    }
} 