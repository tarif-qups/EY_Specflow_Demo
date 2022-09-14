using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.HomePage
{
    public class SupportingOrgPage : PageObjectManager
    {
        private IWebDriver driver;

        private By supportingOrgSection = By.XPath("//h2[contains(text(), \"Supporting organizations \")]");
        private By topicSliderClass = By.XPath("//a[@class=\"topicLink-slide\"]");

        string sliderUrl = "";

        public SupportingOrgPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public void scrollToSupportingOrg()
        {
            Thread.Sleep(3000);
            scrollToElement(supportingOrgSection);
        }

        public bool isSupportingOrgDisplayed()
        {
            waitUntilElementIsVisible(supportingOrgSection);
            return isElementDisplayed(supportingOrgSection);
        }

        public void clickFirstSlider()
        {
            Thread.Sleep(3000);
            IWebElement element = GetWebElements(topicSliderClass)[0];
            sliderUrl = element.GetAttribute("href");

            element.Click();
        }

        public bool isTopicPageLoaded()
        {
            Thread.Sleep(3000);
            if (getCurrentUrl().Equals(sliderUrl))
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
