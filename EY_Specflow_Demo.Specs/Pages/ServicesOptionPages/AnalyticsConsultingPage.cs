using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY_Specflow_Demo.Specs.Pages.ServicesOptionPages
{
    public class AnalyticsConsultingPage : PageObjectManager
    {
        IWebDriver driver;

        private By relatedTopics = By.XPath("//span[contains(text(), \"Related topics\")]");
        private By consultingButton = By.XPath("(//a[contains(text(), \"Consulting\")])[2]");


        public AnalyticsConsultingPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isRelatedTopicsDisplayed()
        {
            waitUntilElementIsVisible(relatedTopics, 2);
            return isElementDisplayed(relatedTopics);
        }

        public void clickConsultingButton()
        {
            clickElement(consultingButton);
        }
    }
}
