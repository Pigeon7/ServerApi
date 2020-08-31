using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace ServerApi.Models
{
    public class SensorsReadingEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }     

        [Required]
        public float TemperatureValue { get; set; }     

        [Required]
        public int  HumidityValue { get; set; }     
        
        [Required]
        public long ReadTimeMilis { get; set; }     
    }
}