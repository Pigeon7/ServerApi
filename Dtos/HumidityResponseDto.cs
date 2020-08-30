using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ServerApi.Dtos
{
    public class HumidityResponseDto
    {
        public List<HumidityResponseItemDto> HumiditiesList { get; set; }
    }
} 