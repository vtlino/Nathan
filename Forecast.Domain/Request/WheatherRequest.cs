using System;

namespace Forecast.Domain.Request
{
    public class WheatherRequest
    {
        public int Temperature { get; set; }
        public DateTime DateCriation { get; set; }
    }
}