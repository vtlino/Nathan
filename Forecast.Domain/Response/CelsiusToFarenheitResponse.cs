namespace Forecast.Domain.Response
{
    public class CelsiusToFarenheitResponse
    {
        public CelsiusToFarenheitResponse(int temperatureCelsius)
        {
            TemperatureCelsiusValue = temperatureCelsius;
        }
        public double TemperatureFarenheitValue { get; set; }
        public int TemperatureCelsiusValue { get; set; }
    }
}