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
    public class TemperaturesController : ControllerBase
    {
        private readonly IDataOutgoingService dataOutgoingService;

        public TemperaturesController(IDataOutgoingService dataOutGoingService) 
        {
            this.dataOutgoingService = dataOutGoingService;
        }
        
        [HttpGet]
        public ActionResult <IEnumerable<TempReadDto>> GetAllTemperatures()
        {
            try
            {
                var sensorReadingList = dataOutgoingService.ReadTemperatures();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("{id}")]
        public ActionResult <TempReadDto> GetTempById(int id)
        {
            try
            {
                var temperatureItem = dataOutgoingService.ReadTemperatureById(id);
                if (temperatureItem != null)
                {
                    return Ok(temperatureItem);
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }

}

