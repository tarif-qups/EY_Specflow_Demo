using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.HomePage
{
    public class CareerOption : PageObjectManager
    {
        IWebDriver driver;

        private By careerOption = By.XPath("(//button[@class=\"main-navigation__l1-tab\"])[4]");
        private By careerWrapper = By.XPath("//div[contains(text(), \"Careers\")]");
        private By jobSearchOption = By.XPath("//a[contains(text(), \"Job search\")]");
        private By exploreButton = By.XPath("//a[@href=\"/en_us/careers\" and contains(text(), \"Explore\")]");

        public CareerOption(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isCareerOptionVisible()
        {
            waitUntilElementIsVisible(careerOption);
            return isElementDisplayed(careerOption);
        }

        public void clickCareerOption()
        {
            clickElement(careerOption);
        }

        public bool isCareerWrapperVisible()
        {
            waitUntilElementIsVisible(careerWrapper);
            return isElementDisplayed(careerWrapper);
        }

        public bool isJobSearchOptionVisible()
        {
            return isElementDisplayed(jobSearchOption);
        }

        public void clickJobSearchOption()
        {
            waitUntilElementIsClickable(jobSearchOption);
            clickElement(jobSearchOption);
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
