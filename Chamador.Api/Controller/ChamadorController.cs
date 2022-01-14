using Forecast.Business;
using Forecast.Domain.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chamador.Api.Controller
{
    [ApiController]
    [Route("caller")]
    public class ChamadorController : ControllerBase
    {
        private readonly CallerBusiness _callerBusiness;

        public ChamadorController(CallerBusiness callerBusiness)
        {
            _callerBusiness = callerBusiness;
        }


        [HttpGet("temperatura-celsius/{temperaturaValor}")]
        public async Task<TemperaturaResponse> ObterTemperatura ([FromRoute] int temperaturaValor)
        {
            var temperaturaFarenheit = await _callerBusiness.ObterTemperaturaFarenheit(temperaturaValor);

            return temperaturaFarenheit;
        }
        [HttpPost("temperatura-celsius/{temperaturaValor}")]
        public async Task<TemperaturaResponse> ObterTemperaturaa ([FromRoute] int temperaturaValor, [FromBody] DateTime xxx)
        {
            var temperaturaFarenheit = await _callerBusiness.ObterTemperaturaFarenheit(temperaturaValor);

            return temperaturaFarenheit;
        }

    }
}