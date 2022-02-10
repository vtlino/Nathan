using Forecast.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Forecast.Business
{
    public class WheatherBusiness
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecastResponse> CastTemperature()
        {
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecastResponse
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureCelsius = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public CelsiusToFarenheitResponse ConvertCelsiusToFarenheit (int temperatureCelsiusValue)
        {
            var temperatureFarenheitValue = (temperatureCelsiusValue * 9) / 5 + 32;
            var transformadaDeLaplace = CalcularTransformadaDeLaplace(temperatureCelsiusValue);

            //TODO: Log
            return new CelsiusToFarenheitResponse(temperatureCelsiusValue) { TemperatureFarenheitValue = temperatureFarenheitValue };
            
        }

        private int CalcularTransformadaDeLaplace(int temperatureCelsiusValue)
        {
            return 0;
        }
    }
}