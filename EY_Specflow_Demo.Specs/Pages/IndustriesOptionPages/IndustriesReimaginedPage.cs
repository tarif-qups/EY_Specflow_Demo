using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.IndustriesOptionPages
{
    public class IndustriesReimaginedPage : PageObjectManager
    {
        IWebDriver driver;

        private By relatedIndustrySection = By.XPath("(//h3[contains(text(), \"Related industry insights\")])[1]");
        private By automotiveOption = By.XPath("//a[@href=\"/en_us/automotive-transportation\"]");

        public IndustriesReimaginedPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public void scrollDownToRelatedIndustrySection()
        {
            Thread.Sleep(3000);
            scrollToElement(relatedIndustrySection);
        }

        public bool isRelatedIndustrySectionDisplayed()
        {
            waitUntilElementIsVisible(relatedIndustrySection);
            return isElementDisplayed(relatedIndustrySection);
        }

        public bool isAutomotiveOptionDisplayed()
        {
            waitUntilElementIsVisible(automotiveOption);
            return isElementDisplayed(automotiveOption);
        }

        public void clickAutomotiveOptionButton()
        {
            JavaScriptClick(automotiveOption);
        }
    }
}
