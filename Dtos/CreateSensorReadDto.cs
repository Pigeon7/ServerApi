using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ServerApi.Dtos
{
    public class CreateSensorReadDto
    {
        public float TemperatureValue { get; set; }     
        public int HumidityValue { get; set; }     
    }
} 