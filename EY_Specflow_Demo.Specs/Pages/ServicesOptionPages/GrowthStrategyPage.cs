using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.ServicesOptionPages
{
    public class GrowthStrategyPage : PageObjectManager
    {
        IWebDriver driver;

        private By eyParthenonHelpSection = By.XPath("//h2[contains(text(), \"How EY-Parthenon can help\")]");
        private By digitalStrategyConsulting = By.XPath("//a[contains(text(), \"Digital strategy consulting\")]");
        private By digitalStrategyConsultingOption = By.XPath("//a[@title=\"Digital strategy consulting for growth\"]");
        private By digitalStrategyConsultingSection = By.XPath("//li[contains(text(),\"Digital strategy – developing a proactive\")]");
        private By showMoreButton = By.XPath("(//button[contains(text(),\"Show more\")])[1]");
        private By showLessButton = By.XPath("(//button[contains(text(),\"Show less\")])[1]");

        public GrowthStrategyPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public void scrollDownToHowEYParthenonCanHelp()
        {
            Thread.Sleep(3000);
            scrollToElement(eyParthenonHelpSection);
        }

        public bool isEYParthenonHelpSectionDisplayed()
        {
            waitUntilElementIsVisible(eyParthenonHelpSection);
            return isElementDisplayed(eyParthenonHelpSection);
        }

        public bool isDigitalStrategyConsultingDisplayed()
        {
            waitUntilElementIsVisible(digitalStrategyConsulting);
            return isElementDisplayed(digitalStrategyConsulting);
        }

        public void clickDigitalStrategyConsulting()
        {
            waitUntilElementIsClickable(digitalStrategyConsulting);
            JavaScriptClick(digitalStrategyConsulting);
        }

        public void scrollToDigitalStrategyConsultingOption()
        {
            Thread.Sleep(3000);
            scrollToElement(digitalStrategyConsultingOption);
        }

        public void clickDigitalStrategyConsultingOption()
        {
            JavaScriptClick(digitalStrategyConsultingOption);
        }

        public bool isDigitalStrategyConsultingDetailsVisible()
        {
            waitUntilElementIsVisible(digitalStrategyConsultingSection);
            return isElementDisplayed(digitalStrategyConsultingSection);
        }

        public void scrollToTeamSection()
        {
            Thread.Sleep(3000);
            scrollToElement(showMoreButton);
        }

        public void clickShowMoreButton()
        {
            Thread.Sleep(3000);
            JavaScriptClick(showMoreButton);
        }

        public bool isMoreTeamMemberDisplayed()
        {
            Thread.Sleep(7000);
            IWebElement element = GetWebElement(showMoreButton);
            if(element.Displayed == false)
            {
                return true;
            }

            else return false;
        }
    }
}
