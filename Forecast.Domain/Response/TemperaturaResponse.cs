using System;

namespace Forecast.Domain.Response
{
    public class TemperaturaResponse
    {
        public TemperaturaResponse(int celsius, double farenheit)
        {
            TemperaturaFarenheitValor = farenheit;
            TemperaturaCelsiusValor = celsius;
        }
        public double TemperaturaFarenheitValor { get; set; }
        public int TemperaturaCelsiusValor { get; set; }
    }
}