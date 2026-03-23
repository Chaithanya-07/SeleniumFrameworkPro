using NUnit.Framework;
using SeleniumFrameworkPro.Base;

namespace SeleniumFrameworkPro.Tests
{
    public class DriverSmokeTest : BaseTest
    {
        [Test]
        public void Open_Google_Test()
        {
            driver.Navigate().GoToUrl("https://google.com");
            Thread.Sleep(3000);
        }
    }
}