
namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestReference()
        {
            WeatherForecast wf = new();
            Assert.True(wf.GetTrue());
        }
    }
}