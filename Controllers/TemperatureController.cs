using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServerApi.Data;
using ServerApi.Dtos;
using ServerApi.Models;
using ServerApi.Services;
using ServerApi.Services.Temperature;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerApi.Controllers
{
    [Route("api/sensors/temperatures")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly ITemperatureService temperatureService;

        public TemperatureController(ITemperatureService temperatureService) 
        {
            this.temperatureService = temperatureService;
        }

        [HttpGet]
        public async Task<ActionResult<TemperatureResponseDto>> GetAllTemperatures()
        {
            var temperaturesList = await temperatureService.ReadAllTemperatures();
            return Ok(temperaturesList);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TemperatureResponseItemDto>> GetTemperatureById(int id)
        {
            var temperatureItem = await temperatureService.ReadTemperatureById(id);
            if (temperatureItem != null)
            {
                return Ok(temperatureItem);
            }
            return NoContent();
        }
    }

}

