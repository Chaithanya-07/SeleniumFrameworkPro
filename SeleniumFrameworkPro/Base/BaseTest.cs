using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumFrameworkPro.Base
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            DriverFactory.InitDriver();
            driver = DriverFactory.GetDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}