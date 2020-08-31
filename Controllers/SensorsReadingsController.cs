using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServerApi.Data;
using ServerApi.Dtos;
using ServerApi.Models;
using ServerApi.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerApi.Controllers
{
    [Route("api/sensors")]
    [ApiController]
    public class SensorsReadingsController : ControllerBase
    {

        private readonly ISensorsReadingService sensorsReadingService;
        public SensorsReadingsController(ISensorsReadingService sensorsReadingService) 
        {
            this.sensorsReadingService = sensorsReadingService;
        }
        
        [HttpPost]
        public async Task<ActionResult> CreateSensorsReadEntity(CreateSensorReadDto dtoEntity)
        {
            await sensorsReadingService.ReceiveSensorData(dtoEntity);
            return Ok();
        }  
        

        /*For now commented below - lets treat this controller as receiver all potential sensors data*/

        //[HttpGet("{id}")]
        //public ActionResult <SensorsReadEntity> GetSensorsReadEntity(int id)
        //{
        //    var sensorsReadEntity = dataOutgoingService.ReadSensorEntityById(id);
        //    try
        //    {
        //        if (sensorsReadEntity != null)
        //        {
        //            return Ok();
        //        }
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.ToString());
        //    }
        //}

    }

}  

