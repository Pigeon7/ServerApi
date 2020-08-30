using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServerApi.Data;
using ServerApi.Dtos;
using ServerApi.Models;
using ServerApi.Services;
using System;
using System.Collections.Generic;

namespace ServerApi.Controllers
{
    [Route("api/sensors/temperatures")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly IDataOutgoingService dataOutgoingService;

        public TemperatureController(IDataOutgoingService dataOutGoingService) 
        {
            dataOutgoingService = dataOutGoingService;
        }

        [HttpGet]
        public ActionResult<TemperatureResponseDto> GetAllTemperatures()
        {
            var temperaturesList = dataOutgoingService.ReadTemperatures();
            return Ok(temperaturesList);
        }

        [HttpGet("{id}")]
        public ActionResult <TemperatureResponseItemDto> GetTemperatureById(int id)
        {
            var temperatureItem = dataOutgoingService.ReadTemperatureById(id);
            if (temperatureItem != null)
            {
                return Ok(temperatureItem);
            }
            return NoContent();
        }
    }

}

