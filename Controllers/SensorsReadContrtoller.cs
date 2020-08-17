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
    [Route("api/sensors")]
    [ApiController]
    public class SensorsReadContrtoller : ControllerBase
    {

        private readonly IDataIncomingService dataIncomingService;
        private readonly IDataOutgoingService dataOutgoingService;
        public SensorsReadContrtoller(IDataIncomingService dataInService, IDataOutgoingService dataOutService) 
        {
            dataIncomingService = dataInService;
            dataOutgoingService = dataOutService; 

        }
        
        [HttpPost]
        public ActionResult <SensorsReadEntity> CreateSensorsReadEntity(CreateSensorReadDto entity)
        {
            try
            {
                dataIncomingService.GetDataAndSave(entity);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        
        [HttpGet("{id}")]
        public ActionResult <SensorsReadEntity> GetSensorsReadEntity(int id)
        {
            var sensorsReadEntity = dataOutgoingService.ReadSensorEntityById(id);
            try
            {
                if (sensorsReadEntity != null)
                {
                    return Ok();
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

