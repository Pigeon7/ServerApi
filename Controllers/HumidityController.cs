using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServerApi.Data;
using ServerApi.Dtos;
using ServerApi.Models;
using ServerApi.Services;
using ServerApi.Services.Humidity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerApi.Controllers
{
    [Route("api/sensors/humidity")]
    [ApiController]
    public class HumidityController : ControllerBase
    {
        private readonly IHumidityService humidityService;
        public HumidityController(IHumidityService humidityService) 
        {
            this.humidityService = humidityService;
        }
        
        [HttpGet]
        public async Task<ActionResult<HumidityResponseDto>> GetAllHumidities()
        {
            var humiditiesList = await humidityService.ReadAllHumidities();
            return Ok(humiditiesList);
        }
         
        [HttpGet("{id}")]
        public async Task<ActionResult<HumidityResponseItemDto>> GetHumidById(int id)
        {
            var humidityItem = await humidityService.ReadHumidityById(id);
            if (humidityItem != null)
            {
                return Ok(humidityItem);
            }
            return NoContent();
        }
    }

}

