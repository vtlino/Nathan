using Forecast.Business;
using Forecast.Domain.Request;
using Forecast.Domain.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace NathanApi.Controllers
{
    [ApiController]
    [Route("weather-forecast")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WheatherBusiness _wheatherBusiness;

        public WeatherForecastController(WheatherBusiness wheatherBusiness)
        {
            _wheatherBusiness = wheatherBusiness;
        }

        [HttpGet("celsius/{temperatureValue}/farenheit/12")]
        public CelsiusToFarenheitResponse GetCelsiusToFarenheit([FromRoute] int temperatureValue, [FromHeader] Guid correlationId)
        {
            //Log aqui
            return _wheatherBusiness.ConvertCelsiusToFarenheit(temperatureValue);
        }

        [HttpGet]
        public IEnumerable<WeatherForecastResponse> Get([FromQuery] int biggerThan)
        {
            return _wheatherBusiness.CastTemperature();
        }

        [HttpPost("temperature")]
        public IEnumerable<WeatherForecastResponse> Post([FromBody] WheatherRequest bodyRequest, [FromHeader] HeaderRequest headerRequest)
        {
            return _wheatherBusiness.CastTemperature();
        }

        [HttpPatch]
        public IEnumerable<WeatherForecastResponse> Patch()
        {
            return _wheatherBusiness.CastTemperature();
        }

        [HttpPut]
        public IEnumerable<WeatherForecastResponse> Put()
        {
            return _wheatherBusiness.CastTemperature();
        }

        [HttpDelete]
        public IEnumerable<WeatherForecastResponse> Delete()
        {
            return _wheatherBusiness.CastTemperature();
        }
    }
}