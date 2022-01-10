using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace XyzAPI.Test
{
    public class WeatherForecastControllerTest: IClassFixture<WeatherForecastControllerTestFixture>
    {
        private readonly WeatherForecastControllerTestFixture _classFixture;

        public WeatherForecastControllerTest(WeatherForecastControllerTestFixture classFixture)
        {
            _classFixture = classFixture;
        }

        [Fact]
        public void Get_Action_Returns_OkObjectResult()
        {
            var okResult = _classFixture.Sut.Get();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }
    }
}