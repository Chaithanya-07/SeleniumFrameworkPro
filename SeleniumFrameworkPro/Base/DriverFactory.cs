using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFrameworkPro.Base
{
    public class DriverFactory
    {
        private static ThreadLocal<IWebDriver> _driver = new ThreadLocal<IWebDriver>();

        public static IWebDriver GetDriver()
        {
            return _driver.Value;
        }

        public static void InitDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            _driver.Value = new ChromeDriver(options);
        }

        public static void QuitDriver()
        {
            _driver.Value.Quit();
            _driver.Value.Dispose();
        }
    }
}