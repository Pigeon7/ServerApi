using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Dtos
{
    public class TemperatureResponseDto
    {
        public List<TemperatureResponseItemDto> TemperaturesList { get; set; }
    }
}
