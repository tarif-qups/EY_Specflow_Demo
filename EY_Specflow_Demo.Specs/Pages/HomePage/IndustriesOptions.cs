using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.HomePage
{
    public class IndustriesOptions : PageObjectManager
    {
        IWebDriver driver;

        private By industriesOption = By.XPath("(//button[@class=\"main-navigation__l1-tab\"])[3]");
        private By industriesWrapper = By.XPath("//div[contains(text(), 'Industries')]");
        private By caseStudies = By.XPath("//div[contains(text(), \"Case studies\")]");
        private By advancedManufacturingOption = By.XPath("//a[contains(text(), \"Advanced manufacturing \")]");
        private By exploreButton = By.XPath("//a[@href=\"/en_us/industry-reimagined\"]");

        public IndustriesOptions(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isIndustriesOptionVisible()
        {
            waitUntilElementIsVisible(industriesOption, 10);
            return isElementDisplayed(industriesOption);
        }

        public void clickIndustriesOption()
        {
            clickElement(industriesOption);
        }

        public bool isIndustriesWrapperDisplayed()
        {
            waitUntilElementIsVisible(industriesWrapper, 2);
            return isElementDisplayed(industriesWrapper);
        }

        public bool isCaseStudiesDisplayed()
        {
            waitUntilElementIsVisible(caseStudies, 2);
            return isElementDisplayed(caseStudies);
        }

        public bool isAdvancedManufacturingDisplayed()
        {
            waitUntilElementIsVisible(advancedManufacturingOption, 2);
            return isElementDisplayed(advancedManufacturingOption);
        }

        public void clickAdvancedManufacturing()
        {
            waitUntilElementIsClickable(advancedManufacturingOption);
            clickElement(advancedManufacturingOption);
        }

        public bool isExploreButtonDisplayed()
        {
            waitUntilElementIsVisible(exploreButton, 2);
            return isElementDisplayed(exploreButton);
        }

        public void clickExploreButton()
        {
            waitUntilElementIsClickable(exploreButton);
            JavaScriptClick(exploreButton);
            Thread.Sleep(3000);
        }
    }
}
