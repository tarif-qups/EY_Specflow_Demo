using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.AboutOptionPage
{
    public class OurPeopleOptionPage : PageObjectManager
    {
        IWebDriver driver;

        private By ourPeopleSection = By.XPath("(//h2[contains(text(), \"Our people\")])");
        private By readMoreButton = By.XPath("(//a[contains(text(), \"Read more\")])[2]");
        private By readLessButton = By.XPath("(//a[contains(text(), \"Read less\")])[2]");
        private By eyBadgesLink = By.XPath("(//a[contains(text(), \"EY Badges\")])");

        public OurPeopleOptionPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isOurPeopleSectionVisible()
        {
            waitUntilElementIsVisible(ourPeopleSection, 15);
            return isElementDisplayed(ourPeopleSection);
        }

        public void clickReadMoreButton()
        {
            waitUntilElementIsClickable(readMoreButton);
            clickElement(readMoreButton);
        }

        public bool isMoreInformationDisplayed()
        {
            Thread.Sleep(2000);
            return isElementDisplayed(readLessButton);
        }

        public bool isEYBadgeLinkVisible()
        {
            Thread.Sleep(3000);
            return isElementDisplayed(eyBadgesLink);
        }

        public void clickEYBadgeLink()
        {
            waitUntilElementIsClickable(eyBadgesLink);
            JavaScriptClick(eyBadgesLink);
        }
    }
}
