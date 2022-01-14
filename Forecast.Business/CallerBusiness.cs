using Forecast.Domain.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Business
{
    public class CallerBusiness
    {
        public async Task<TemperaturaResponse> ObterTemperaturaFarenheit(int temperaturaValor)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:5001/");

            var resposta = await httpClient.GetAsync($"weather-forecast/celsius/{temperaturaValor}/farenheit");
            string responseBody = await resposta.Content.ReadAsStringAsync();

            var respostaDeserializada = JsonConvert.DeserializeObject<CelsiusToFarenheitApiResponse>(responseBody);
            return new TemperaturaResponse(respostaDeserializada.temperatureCelsiusValue, respostaDeserializada.temperatureFarenheitValue);
        }
    }
}