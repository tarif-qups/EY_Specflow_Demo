using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.InsightsOptionPages
{
    public class TransformationPage : PageObjectManager
    {
        IWebDriver driver;

        private By ceoAgendaSection = By.XPath("//h3[contains(text(), \"CEO agenda\")]");
        private By discoverMoreButton = By.XPath("(//a[contains(text(), \"Discover more\")])[1]");

        public TransformationPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public void scrollDownToCEOAgendaSection()
        {
            Thread.Sleep(3000);
            scrollToElement(ceoAgendaSection);
        }

        public bool isCEOSectionDisplayed()
        {
            waitUntilElementIsVisible(ceoAgendaSection);
            return isElementDisplayed(ceoAgendaSection);
        }

        public bool isDiscoverMoreButtonDisplayed()
        {
            waitUntilElementIsVisible(discoverMoreButton, 2);
            return isElementDisplayed(discoverMoreButton);
        }

        public void clickDiscoverMoreButton()
        {
            Thread.Sleep(3000);
            JavaScriptClick(discoverMoreButton);
        }
    }
}
