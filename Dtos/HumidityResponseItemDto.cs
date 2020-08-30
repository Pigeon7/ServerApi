using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Dtos
{
    public class HumidityResponseItemDto
    {
        public int Id { get; set; }

        public int HumidityValue { get; set; }

        public long ReadTimeMilis { get; set; }
    }
}
