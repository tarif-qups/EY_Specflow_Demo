using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.Footers
{
    public class LocationsPage : PageObjectManager
    {
        private IWebDriver driver;

        private By ourLocationsLink = By.XPath("(//a[@href=\"/en_us/locations\"])[2]");
        private By searchInputField = By.XPath("//input[@name=\"inlineSearchQuery\"]");
        private By searchResultList = By.XPath("//ul[@class=\"inlineSearch-results hidden\"]");
        private By searchedListItem = By.XPath("//a[@href=\"/en_us/locations/united-states#california\"]");
        private By californiaSection = By.XPath("//span[contains(text(), \"California\")]");
        private By irvineSection = By.XPath("//a[@title=\"Irvine\"]");
        private By detailsSection = By.XPath("//div[@id=\"accordion-content-01740634514-3\"]");

        public LocationsPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isOurLocationVisible()
        {
            return isElementDisplayed(ourLocationsLink);
        }

        public void clickOurLocation()
        {
            Thread.Sleep(3000);
            clickElement(ourLocationsLink);
        }

        public bool isSearchFieldVisible()
        {
            waitUntilElementIsVisible(searchInputField);
            return isElementDisplayed(searchInputField);
        }

        public void enterSearchValue(String text)
        {
            scrollToElement(searchInputField);
            //        clickElement(searchInputField);
            SendKeysToElement(searchInputField, text);
            Thread.Sleep(3000);
        }

        public bool isResultListDisplayed()
        {
            scrollToElement(searchResultList);
            waitUntilElementIsVisible(searchResultList);
            return isElementDisplayed(searchResultList);
        }

        public void clickListItem()
        {
            JavaScriptClick(searchedListItem);
        }

        public bool isSearchedLocationDisplayed()
        {
            waitUntilElementIsVisible(californiaSection);
            return isElementDisplayed(californiaSection);
        }

        public bool isIrvineSectionDisplayed()
        {
            waitUntilElementIsVisible(irvineSection);
            return isElementDisplayed(irvineSection);
        }

        public void clickCaliforniaText()
        {
            clickElement(californiaSection);
        }

        public bool isDetailsHidden()
        {
            Thread.Sleep(2000);
            IWebElement element = GetWebElement(detailsSection);

            if (element.GetAttribute("style").Equals("display: none;"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
