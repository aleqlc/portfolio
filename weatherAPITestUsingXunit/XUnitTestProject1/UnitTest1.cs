using System;
using System.Linq;
using WebAPITestUsingXunit.Controllers;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private ITestOutputHelper logger;
        public UnitTest1(ITestOutputHelper logger)
        {
            this.logger = logger;
        }

        [Fact]
        public void TestGetCount()
        {
            var controller = new WeatherForecastController(null);
            var data = controller.Get();

            foreach(var weather in data)
            {
                logger.WriteLine
                    ($"{weather.Date}:{weather.TemperatureC},{weather.Summary}");
            }

            int expected = 5;
            int actual = data.ToList().Count;//data.Count();¶û °°À½

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGet()
        {
            var controller = new WeatherForecastController(null);
            var data = controller.Get();

            int expected = 5;
            int actual = data.ToList().Count;//data.Count();¶û °°À½

            Assert.Equal(expected, actual);
        }
    }
}
