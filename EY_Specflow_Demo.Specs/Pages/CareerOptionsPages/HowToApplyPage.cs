using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.CareerOptionsPages
{
    public class HowToApplyPage : PageObjectManager
    {
        IWebDriver driver;

        private By howToApplyButton = By.XPath("//a[contains(text(), \"How to apply\")]");
        private By hiringProcessSection = By.XPath("//h3[contains(text(), \"Hiring process for students\")]");
        private By stepOne = By.XPath("//span[contains(text(), \"Step one: Explore EY\")]");
        private By stepDetails = By.XPath("//u[contains(text(), \"Learn about the opportunities\")]");
        public HowToApplyPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public void scrollToStudentsSection()
        {
            Thread.Sleep(3000);
            scrollToElement(howToApplyButton);
        }

        public bool isHowToApplyBtnVisible()
        {
            waitUntilElementIsVisible(howToApplyButton);
            return isElementDisplayed(howToApplyButton);
        }

        public void clickHowToApplyBtn()
        {
            JavaScriptClick(howToApplyButton);
        }

        public bool isHiringProcessSectionDisplayed()
        {
            waitUntilElementIsVisible(hiringProcessSection, 10);
            return isElementDisplayed(hiringProcessSection);
        }

        public void scrollToProcesses()
        {
            scrollToElement(stepOne);
        }

        public bool isStepDisplayed()
        {
            waitUntilElementIsVisible(stepOne);
            return isElementDisplayed(stepOne);
        }

        public void clickStepOne()
        {
            JavaScriptClick(stepOne);
        }

        public bool areDetailsDisplayed()
        {
            waitUntilElementIsVisible(stepDetails);
            return isElementDisplayed(stepDetails);
        }
    }
}
