using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.InsightsOptionPages
{
    public class LongTermValuePage : PageObjectManager
    {
        IWebDriver driver;

        private By eyValueRealized = By.XPath("//h3[contains(text(), \"EY Value Realized\")]");
        private By exploreButton = By.XPath("(//a[@href=\"/en_us/global-review/value-realized-2021\"])[2]");
        private By showResourcesSection = By.XPath("(//h2[contains(text(), \"Show resources\")])[1]");
        private By downloadOption = By.XPath("(//div[@class=\"fileList-download\"])[1]");

        public LongTermValuePage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public void scrollToEYValueSection()
        {
            Thread.Sleep(3000);
            scrollToElement(eyValueRealized);
        }

        public bool isEyValueRealizedSectionVisible()
        {
            waitUntilElementIsVisible(eyValueRealized);
            return isElementDisplayed(eyValueRealized);
        }

        public bool isExploreButtonDisplayed()
        {
            waitUntilElementIsVisible(exploreButton);
            return isElementDisplayed(exploreButton);
        }

        public void clickExploreButton()
        {
            JavaScriptClick(exploreButton);
        }

        public void scrollToShowResources()
        {
            Thread.Sleep(3000);
            scrollToElement(showResourcesSection);
        }

        public bool isShowResourcesVisible()
        {
            waitUntilElementIsVisible(showResourcesSection);
            return isElementDisplayed(showResourcesSection);
        }

        public void clickShowResourcesButton()
        {
            JavaScriptClick(showResourcesSection);
        }

        public bool isDownloadOptionVisible()
        {
            waitUntilElementIsVisible(downloadOption);
            return isElementDisplayed(downloadOption);
        }
    }
}
