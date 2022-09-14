using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.HomePage
{
    public class HomePage : PageObjectManager
    {
        private IWebDriver _driver;

        /**
         * Locators
         */
        private By cookiePolicyBox = By.Id("cookiePolicy-text");
        private By acceptAllCookiesButton = By.XPath("//button[@class=\"cookiePolicy-accept\"]");
        private By mainNavigationBar = By.XPath("//div[@class=\"main-navigation__wrapper\"]");
        private By footerSection = By.Id("footer");

        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        public bool isCookiePopupDisplayed()
        {
            waitUntilElementIsVisible(cookiePolicyBox, 10);
            return isElementDisplayed(cookiePolicyBox);
        }

        public void clickAcceptPolicyButton()
        {
            waitUntilElementIsClickable(acceptAllCookiesButton);
            clickElement(acceptAllCookiesButton);
            Thread.Sleep(3000);
        }

        public bool isHomepageDisplayedWithoutPopup()
        {
            bool temp = false;
            waitUntilElementIsVisible(mainNavigationBar);

            if (isElementDisplayed(mainNavigationBar) == true)
            {
                try
                {
                    _driver.FindElement(cookiePolicyBox);
                    temp = false;
                }
                catch (OpenQA.Selenium.NoSuchElementException e)
                {
                    temp = true;
                }
            }
            return temp;
        }

        /**
         * scroll to footer
         */
        public void scrollToFooter()
        {
            Thread.Sleep(3000);
            scrollToElement(footerSection);
        }

        /**
         * @return true if footer section is displayed
         */
        public bool isFooterDisplayed()
        {
            waitUntilElementIsVisible(footerSection);
            return isElementDisplayed(footerSection);
        }
    }
}
