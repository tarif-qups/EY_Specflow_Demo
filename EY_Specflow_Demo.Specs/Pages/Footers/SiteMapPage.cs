using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.Footers
{
    public class SiteMapPage : PageObjectManager
    {
        IWebDriver driver;

        private By siteMapLink = By.XPath("//a[@href=\"/en_us/sitemap\"]");
        private By legalSection = By.XPath("//a[@title=\"Legal\"]");
        private By eyEthicsLink = By.XPath("//a[@title=\"EY/Ethics Hotline\"]");
        private By newsSection = By.XPath("//a[@title=\"News\"]");
        private By pressReleaseLink = By.XPath("//a[@title=\"2022 press releases\"]");

        public SiteMapPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isSiteMapLinkVisible()
        {
            Thread.Sleep(3000);
            return isElementDisplayed(siteMapLink);
        }

        public void clickSiteMapLink()
        {
            clickElement(siteMapLink);
        }

        public bool isLegalSectionVisible()
        {
            waitUntilElementIsVisible(legalSection);
            return isElementDisplayed(legalSection);
        }

        public bool isEYEthicsLinkVisible()
        {
            return isElementDisplayed(eyEthicsLink);
        }

        public void clickEYEthicsLink()
        {
            clickElement(eyEthicsLink);
        }

        public bool isNewsSectionVisible()
        {
            waitUntilElementIsVisible(newsSection);
            return isElementDisplayed(newsSection);
        }

        public bool isPressReleasesVisible()
        {
            return isElementDisplayed(pressReleaseLink);
        }

        public void clickPressReleasesLink()
        {
            clickElement(pressReleaseLink);
        }
    }
}
