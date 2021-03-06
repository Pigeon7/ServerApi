using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ServerApi.Dtos
{
    public class TemperatureResponseItemDto
    {
        public int Id { get; set; }     

        public float TemperatureValue { get; set; }     
        
        public long ReadTimeMilis { get; set; }     
    }
} 