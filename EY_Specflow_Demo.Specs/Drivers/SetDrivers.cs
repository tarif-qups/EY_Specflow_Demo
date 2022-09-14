using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY_Specflow_Demo.Specs.Drivers
{
    public class SetDrivers
    {
        private Lazy<IWebDriver> _driver;

        public SetDrivers()
        {
            _driver = new Lazy<IWebDriver>(Setup);
        }

        public IWebDriver Current => _driver.Value;

        public IWebDriver Setup()
        {
            var chromeDriver = ChromeDriverService.CreateDefaultService();
            var browserOption = GetBrowserOptions("chrome");
            var driver = new ChromeDriver(chromeDriver, browserOption);

            driver.Manage().Window.Maximize();
            return driver;
        }

        private dynamic GetBrowserOptions(String browserName)
        {
            if (browserName.ToLower() == "chrome")
            {
                return new ChromeOptions();
            }
            else if (browserName.ToLower() == "firefox")
            {
                return new FirefoxOptions();
            }
            else
            {
                return new ChromeOptions();
            }
        }
    }
}
