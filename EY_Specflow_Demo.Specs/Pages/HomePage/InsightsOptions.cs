using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY_Specflow_Demo.Specs.Pages.HomePage
{
    public class InsightsOptions : PageObjectManager
    {
        IWebDriver driver;

        private By insightOption = By.XPath("(//button[@class=\"main-navigation__l1-tab\"])[1]");
        private By insightsWrapper = By.XPath("(//div[@role=\"tabpanel\"])[1]");
        private By trendingTopics = By.XPath("//div[contains(text(), \"Trending topics\")]");
        private By cSuiteAgendas = By.XPath("//div[contains(text(), \"Trending topics\")]");
        private By technologyOption = By.XPath("//a[@class=\"main-navigation__l2s2-link\" and @href=\"/en_us/technology\"]");
        private By transformationOption = By.XPath("(//a[contains(text(), \"Transformation\")])[1]");
        private By longTermValueOption = By.XPath("(//a[contains(text(), \"Long-term value\")])[1]");

        public InsightsOptions(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isInsightOptionAvailable()
        {
            waitUntilElementIsVisible(insightOption);
            return isElementDisplayed(insightOption);
        }

        public void clickInsightOption()
        {
            waitUntilElementIsClickable(insightOption);
            clickElement(insightOption);
        }

        public bool isInsightsWrapperVisible()
        {
            waitUntilElementIsVisible(insightsWrapper, 2);
            return isElementDisplayed(insightsWrapper);
        }

        public bool isTrendingTopicVisible()
        {
            waitUntilElementIsVisible(trendingTopics, 2);
            return isElementDisplayed(trendingTopics);
        }

        public bool isCSuiteVisible()
        {
            waitUntilElementIsVisible(cSuiteAgendas, 2);
            return isElementDisplayed(cSuiteAgendas);
        }

        public void clickTechnologyOption()
        {
            waitUntilElementIsClickable(technologyOption);
            clickElement(technologyOption);
        }

        public bool isTransformationOptionVisible()
        {
            waitUntilElementIsVisible(transformationOption, 2);
            return isElementDisplayed(transformationOption);
        }

        public bool isLongTermValueOptionVisible()
        {
            waitUntilElementIsVisible(longTermValueOption, 2);
            return isElementDisplayed(longTermValueOption);
        }

        public void clickTransformationOption()
        {
            waitUntilElementIsClickable(transformationOption);
            clickElement(transformationOption);
        }

        public void clickLongTermValueOption()
        {
            waitUntilElementIsClickable(longTermValueOption);
            clickElement(longTermValueOption);
        }
    }
}
