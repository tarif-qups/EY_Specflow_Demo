using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.ServicesOptionPages
{
    public class ServicesPage : PageObjectManager
    {
        IWebDriver driver;

        private By ourAlliancesSection = By.XPath("//h1[contains(text(), \"Our alliances\")]");
        private By findOutMoreButton = By.XPath("//a[contains(text(), \"Find out more\")]");

        public ServicesPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public void scrollDownToOurAlliancesSection()
        {
            Thread.Sleep(3000);
            scrollToElement(ourAlliancesSection);
        }

        public bool isOurAlliancesSectionDisplayed()
        {
            waitUntilElementIsVisible(ourAlliancesSection);
            return isElementDisplayed(ourAlliancesSection);
        }

        public bool isOFindOutMoreButtonDisplayed()
        {
            scrollToElement(findOutMoreButton);
            waitUntilElementIsVisible(findOutMoreButton);
            return isElementDisplayed(findOutMoreButton);
        }

        public void clickFindOutMoreButton()
        {
            JavaScriptClick(findOutMoreButton);
        }
    }
}
