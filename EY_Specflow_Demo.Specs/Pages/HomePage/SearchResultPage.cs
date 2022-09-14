using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.HomePage
{
    public class SearchResultPage : PageObjectManager
    {
        private IWebDriver _driver;

        private By searchButton = By.XPath("//div[@class=\"main-navigation__button-search\"]");
        private By searchInputField = By.XPath("//input[@type=\"search\"]");
        private By trendingSection = By.XPath("//div[@class=\"trending-section\"]");
        private By topicsSection = By.XPath("//div[@class=\"instant-search-row topics\"]");
        private By generalSection = By.XPath("//h3[contains(text(), \"General\")]");
        private By peopleSection = By.XPath("//div[@class=\"instant-search-row person\"]");
        private By sortBySection = By.XPath("//div[@class=\"order-type-items\"]");
        private By filtersSection = By.XPath("//div[@class=\"searchFilter-content\"]");
        private By aboutCheckbox = By.XPath("(//div[@class=\"filter-input\"])[1]");
        private By searchResultCount = By.XPath("//div[@class=\"global-search-results-number component\"]/p/span");

        private int count = 0;

        public SearchResultPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        public bool isSearchButtonVisible()
        {
            waitUntilElementIsVisible(searchButton);
            return isElementDisplayed(searchButton);
        }

        public void clickSearchButton()
        {
            clickElement(searchButton);
        }

        public bool isSearchInputFieldVisible()
        {
            waitUntilElementIsVisible(searchInputField);
            return isElementDisplayed(searchInputField);
        }

        public bool isTrendingSectionVisible()
        {
            waitUntilElementIsVisible(trendingSection);
            return isElementDisplayed(trendingSection);
        }

        public void insertInput(String text)
        {
            SendKeysToElement(searchInputField, text);
        }

        public bool isTopicSectionVisible()
        {
            waitUntilElementIsVisible(topicsSection);
            return isElementDisplayed(topicsSection);
        }

        public bool isGeneralSectionVisible()
        {
            waitUntilElementIsVisible(generalSection);
            return isElementDisplayed(generalSection);
        }

        public bool isPeopleSectionVisible()
        {
            waitUntilElementIsVisible(peopleSection);
            return isElementDisplayed(peopleSection);
        }

        public void pressEnter()
        {
            GetWebElement(searchInputField).SendKeys(Keys.Enter);
        }

        public bool isSortingOptionVisible()
        {
            waitUntilElementIsVisible(sortBySection, 10);
            return isElementDisplayed(sortBySection);
        }

        public bool isFilterVisible()
        {
            waitUntilElementIsVisible(filtersSection, 10);
            return isElementDisplayed(filtersSection);
        }

        public void clickAboutCheckbox()
        {
            count = int.Parse(GetTextOfElement(searchResultCount));
            clickElement(aboutCheckbox);
        }

        public bool isPageFiltered()
        {
            Thread.Sleep(5000);
            int count1 = int.Parse(GetTextOfElement(searchResultCount));
            if (count1 != count)
            {
                return true;
            }
            else return false;
        }
    }
}
