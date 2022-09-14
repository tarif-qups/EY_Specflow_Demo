using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.InsightsOptionPages
{
    public class TechnologyPage : PageObjectManager
    {
        IWebDriver driver;


        private By readMoreButton = By.XPath("(//a[contains(text(), \"Read more\")])[1]");
        private By readLessButton = By.XPath("(//a[contains(text(), \"Read less\")])[1]");
        private By ourLatestThinkingContainer = By.XPath("//h3[contains(text(), \"Our latest thinking\")]");
        private By articleImageEY = By.XPath("(//img[@class= \"article-image\"])[1]");
        private By facebookIcon = By.XPath("//li[@class= \"shareThis-item odd first \"]/a");

        public TechnologyPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public void clickReadMoreButton()
        {
            waitUntilElementIsClickable(readMoreButton);
            clickElement(readMoreButton);
        }

        public bool isMoreInformationDisplayed()
        {
            waitUntilElementIsVisible(readLessButton);
            return isElementDisplayed(readLessButton);
        }

        public void scrollDownTechnologyPage()
        {
            scrollToElement(ourLatestThinkingContainer);
        }

        public bool isOurLatestThinkContainerVisible()
        {
            waitUntilElementIsVisible(ourLatestThinkingContainer, 2);
            return isElementDisplayed(ourLatestThinkingContainer);
        }

        public bool isArticleTitleImageDisplayed()
        {
            waitUntilElementIsVisible(articleImageEY);
            return isElementDisplayed(articleImageEY);
        }

        public void clickArticleImage()
        {
            clickElement(articleImageEY);
        }

        public void scrollDownArticlePage()
        {
            Thread.Sleep(3000);
            scrollToElement(facebookIcon);
        }

        public bool isShowReferencesTextDisplayed()
        {
            waitUntilElementIsVisible(facebookIcon, 10);
            return isElementDisplayed(facebookIcon);
        }

        public void clickFacebookIcon()
        {
            waitUntilElementIsClickable(facebookIcon);
            JavaScriptClick(facebookIcon);
        }

        public bool isFacebookPageLoaded()
        {
            return isTabOpened("Facebook");
        }
    }
}
