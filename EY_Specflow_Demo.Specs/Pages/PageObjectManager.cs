using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages
{
    public class PageObjectManager
    {
        private const string url = "https://www.ey.com/en_us";

        private readonly IWebDriver _webDriver;

        public PageObjectManager(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void loadUrl()
        {
            _webDriver.Url = url;
        }

        public void tearDown()
        {
            if (_webDriver != null)
            {
                _webDriver.Quit();
            }
        }

        public String getCurrentUrl()
        {
            return _webDriver.Url;
        }

        protected void clickElement(By locator)
        {
            waitUntilElementIsClickable(locator);
            _webDriver.FindElement(locator).Click();
        }

        protected void JavaScriptClick(By locator)
        {
            IWebElement element = GetWebElement(locator);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)_webDriver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        protected void JavaScriptClickElement(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)_webDriver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        protected bool isElementDisplayed(By locator)
        {
            return _webDriver.FindElement(locator).Displayed;
        }

        protected void SendKeysToElement(By locator, String inputText)
        {
            _webDriver.FindElement(locator).SendKeys(inputText);
        }


        protected IList<IWebElement> GetWebElements(By locator)
        {
            return _webDriver.FindElements(locator);
        }

        protected IWebElement GetWebElement(By locator)
        {
            return _webDriver.FindElement(locator);
        }

        protected String GetTextOfElement(By locator)
        {
            return _webDriver.FindElement(locator).Text;
        }

        protected void scrollToElement(By locator)
        {
            IWebElement element = _webDriver.FindElement(locator);
            IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }


        protected void waitUntilElementIsClickable(By locator)
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        protected void waitUntilElementIsVisible(By locator)
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        protected void waitUntilElementIsVisible(By locator, double time)
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        protected bool isTabOpened(string title)
        {
            string originalWindow = _webDriver.CurrentWindowHandle;

            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.());
            Thread.Sleep(5000);

            foreach(string window in _webDriver.WindowHandles)
            {
                if (!originalWindow.Equals(window))
                {
                    _webDriver.SwitchTo().Window(window);
                    break;
                }
            }
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains(title));
            return _webDriver.Title.Contains(title);
        }
    }
}
