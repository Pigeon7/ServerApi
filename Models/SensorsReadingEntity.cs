using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ServerApi.Models
{
    public class SensorsReadingEntity
    {
        [Key]
        public int Id {get; set;}     

        [Required]
        public float TemperatureValue {get; set;}     

        [Required]
        public int  HumidityValue {get; set;}     
        
        [Required]
        public long ReadTimeMilis {get; set;}     
    }
}