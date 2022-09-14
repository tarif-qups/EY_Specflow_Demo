using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY_Specflow_Demo.Specs.Pages.HomePage
{
    public class ServicesOptions : PageObjectManager
    {
        IWebDriver driver;

        private By servicesOption = By.XPath("(//button[@class=\"main-navigation__l1-tab\"])[2]");
        private By servicesWrapper = By.XPath("(//div[@role=\"tabpanel\"])[2]");
        private By spotlightText = By.XPath("(//div[contains(text(), \"Spotlight\")])[1]");
        private By strategyByEYParthenonOption = By.XPath("//button[contains(text(), \"Strategy by EY-Parthenon\")]");
        private By strategyByEYParthenonList = By.XPath("//div[contains(text(), \"Strategy by EY-Parthenon\")]");
        private By corporateAndGrowthOption = By.XPath("//a[contains(text(), \"Corporate and growth strategy\")]");
        private By consultingOption = By.XPath("//button[contains(text(), \"Consulting\")]");
        private By analyticsConsultingOption = By.XPath("//a[contains(text(), \"Analytics consulting services\")]");
        private By exploreButton = By.XPath("(//a[contains(text(), \" Explore \")])[2]");

        public ServicesOptions(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isServicesOptionVisible()
        {
            waitUntilElementIsVisible(servicesOption, 10);
            return isElementDisplayed(servicesOption);
        }

        public void clickServicesOption()
        {
            clickElement(servicesOption);
        }

        public bool isServicesWrapperDisplayed()
        {
            waitUntilElementIsVisible(servicesWrapper, 2);
            return isElementDisplayed(servicesWrapper);
        }

        public bool isSpotlightDisplayed()
        {
            waitUntilElementIsVisible(spotlightText, 2);
            return isElementDisplayed(spotlightText);
        }

        public void clickStrategyByEYParthenonOption()
        {
            clickElement(strategyByEYParthenonOption);
        }

        public bool isStrategyByEYParthenonListDisplayed()
        {
            waitUntilElementIsVisible(strategyByEYParthenonList);
            return isElementDisplayed(strategyByEYParthenonList);
        }

        public void clickCorporateAndGrowthOption()
        {
            clickElement(corporateAndGrowthOption);
        }

        public bool isConsultingDisplayed()
        {
            waitUntilElementIsVisible(consultingOption, 2);
            return isElementDisplayed(consultingOption);
        }

        public void clickConsultingOption()
        {
            clickElement(consultingOption);
        }

        public bool isAnalyticsConsultingDisplayed()
        {
            waitUntilElementIsVisible(analyticsConsultingOption, 2);
            return isElementDisplayed(analyticsConsultingOption);
        }

        public void clickAnalyticsConsultingOption()
        {
            clickElement(analyticsConsultingOption);
        }

        public bool isExploreButtonDisplayed()
        {
            waitUntilElementIsVisible(exploreButton, 2);
            return isElementDisplayed(exploreButton);
        }

        public void clickExploreOption()
        {
            clickElement(exploreButton);
        }
    }
}
