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
    [Route("api/sensors/humidity")]
    [ApiController]
    public class HumidityController : ControllerBase
    {
        private readonly IDataOutgoingService dataOutgoingService;
        public HumidityController(IDataOutgoingService dataOutgoingService) 
        {
            this.dataOutgoingService = dataOutgoingService;
        }
        
        [HttpGet]
        public ActionResult <IEnumerable<HumidReadDto>> GetAllHumidities()
        {
            try
            {
                var sensorReadingList = dataOutgoingService.ReadHumidities();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
         
        [HttpGet("{id}")]
        public ActionResult <HumidReadDto> GetHumidById(int id)
        {
            try 
            {
                var humidityItem = dataOutgoingService.ReadHumidityById(id);
                if (humidityItem != null)
                {
                    return Ok(humidityItem);
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

