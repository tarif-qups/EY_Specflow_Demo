using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.Footers
{
    public class WebcastsPage : PageObjectManager
    {
        private IWebDriver driver;

        private By webcastsLink = By.XPath("//a[@href=\"/en_us/webcasts\"]");
        private By webcastList = By.XPath("//div[@class=\"row eventList-wrapper\"]");
        private By firstDetailsBtn = By.XPath("(//a[contains(text(), \"Full details\")])[1]");
        private By registerBtn = By.XPath("//a[contains(text(), \"Register\")]");
        private By registerForm = By.XPath("//div[@class=\"overlay-content\"]");

        private String webcastsUrl = "";

        public WebcastsPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isWebcastsLinkVisible()
        {
            return isElementDisplayed(webcastsLink);
        }

        public void clickWebcastsLink()
        {
            Thread.Sleep(3000);
            clickElement(webcastsLink);
        }

        public bool isWebcastsListVisible()
        {
            waitUntilElementIsVisible(webcastList);
            return isElementDisplayed(webcastList);
        }

        public void clickDetailBtn()
        {
            Thread.Sleep(3000);
            scrollToElement(firstDetailsBtn);
            webcastsUrl = GetWebElement(firstDetailsBtn).GetAttribute("href");
            JavaScriptClick(firstDetailsBtn);
        }

        public bool isDetailsPageLoaded()
        {
            Thread.Sleep(5000);
            if (getCurrentUrl().Equals(webcastsUrl))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isRegisterButtonDisplayed()
        {
            waitUntilElementIsVisible(registerBtn);
            return isElementDisplayed(registerBtn);
        }

        public void clickRegisterBtn()
        {
            Thread.Sleep(3000);
            JavaScriptClick(registerBtn);
        }

        public bool isRegisterFormDisplayed()
        {
            waitUntilElementIsVisible(registerForm);
            return isElementDisplayed(registerForm);
        }
    }
}
