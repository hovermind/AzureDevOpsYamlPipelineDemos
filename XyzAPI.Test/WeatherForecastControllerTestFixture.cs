using System;
using Microsoft.Extensions.Logging;
using Moq;
using XyzAPI.Controllers;

namespace XyzAPI.Test
{
    public class WeatherForecastControllerTestFixture : IDisposable
    {
        public WeatherForecastController Sut { get; private set; }

        public WeatherForecastControllerTestFixture()
        {
            var mockedLogger = new Mock<ILogger<WeatherForecastController>>();

            Sut = new WeatherForecastController(mockedLogger.Object);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
