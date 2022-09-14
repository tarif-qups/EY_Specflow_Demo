using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.HomePage
{
    public class TrendingNowPage : PageObjectManager
    {
        private IWebDriver driver;

        private By trendingNowSection = By.XPath("//h2[contains(text(), \"Trending now\")]");
        private By metaverseTopic = By.XPath("//span[contains(text(), \"metaverse\")]");
        private By learnMoreButton = By.XPath("(//a[contains(text(), \"Learn more\")])[2]");
        private By upvoteButton = By.XPath("(//a[contains(text(), \"Upvote\")])[1]");
        private By upvoteCounter = By.XPath("(//span[@class=\"upvote-counter\"])[1]");

        private int voteCount = 0;

        public TrendingNowPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public void scrollToTrendingSection()
        {
            Thread.Sleep(3000);
            scrollToElement(trendingNowSection);
        }

        public bool isTrendingNowSectionDisplayed()
        {
            waitUntilElementIsVisible(trendingNowSection);
            return isElementDisplayed(trendingNowSection);
        }

        public bool isMetaverseTopicVisible()
        {
            waitUntilElementIsVisible(metaverseTopic);
            return isElementDisplayed(metaverseTopic);
        }

        public bool isLearnMoreBtnVisible()
        {
            waitUntilElementIsVisible(learnMoreButton);
            return isElementDisplayed(learnMoreButton);
        }

        public void clickLearnMoreButton()
        {
            JavaScriptClick(learnMoreButton);
        }

        public void scrollToUpvoteSection()
        {
            Thread.Sleep(2000);
            scrollToElement(upvoteButton);
        }

        public bool isUpvoteSectionDisplayed()
        {
            waitUntilElementIsVisible(upvoteButton);
            return isElementDisplayed(upvoteButton);
        }

        public void clickUpvoteBtn()
        {
            voteCount = int.Parse(GetWebElement(upvoteCounter).Text);
            JavaScriptClick(upvoteButton);
        }

        public bool isVoteCountIncreased()
        {
            Thread.Sleep(5000);
        int count = int.Parse(GetWebElement(upvoteCounter).Text);

        Console.WriteLine("Before: "+ voteCount);
        Console.WriteLine("After: "+ count);

        if(count > voteCount){
            return true;
        }else {
            return false;
        }
    }
}
}
