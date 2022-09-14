using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.HomePage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class TrendingNowPageSteps
    {
        private TrendingNowPage trendingNowPage;

        public TrendingNowPageSteps(SetDrivers driver)
        {
            trendingNowPage = new TrendingNowPage(driver.Current);
        }

        [When(@"User scrolls down to Trending now section")]
        public void WhenUserScrollsDownToTrendingNowSection()
        {
            trendingNowPage.scrollToTrendingSection();
        }

        [Then(@"Trending now section should be displayed")]
        public void ThenTrendingNowSectionShouldBeDisplayed()
        {
            Assert.IsTrue(trendingNowPage.isTrendingNowSectionDisplayed());
        }

        [Then(@"Article on Metaverse should be displayed")]
        public void ThenArticleOnMetaverseShouldBeDisplayed()
        {
            Assert.IsTrue(trendingNowPage.isMetaverseTopicVisible());
        }

        [Then(@"Learn more button should be displayed")]
        public void ThenLearnMoreButtonShouldBeDisplayed()
        {
            Assert.IsTrue(trendingNowPage.isLearnMoreBtnVisible());
        }

        [When(@"User clicks on learn more button")]
        public void WhenUserClicksOnLearnMoreButton()
        {
            trendingNowPage.clickLearnMoreButton();
        }

        [Then(@"Metaverse article page should be displayed")]
        public void ThenMetaverseArticlePageShouldBeDisplayed()
        {
            Assert.IsTrue(trendingNowPage.getCurrentUrl().Contains("the-metaverse"));
        }

        [When(@"User scrolls down to Upvote section")]
        public void WhenUserScrollsDownToUpvoteSection()
        {
            trendingNowPage.scrollToUpvoteSection();
        }

        [Then(@"Upvote button should be displayed")]
        public void ThenUpvoteButtonShouldBeDisplayed()
        {
            Assert.IsTrue(trendingNowPage.isUpvoteSectionDisplayed());
        }

        [When(@"User clicks on Upvote button")]
        public void WhenUserClicksOnUpvoteButton()
        {
            trendingNowPage.clickUpvoteBtn();
        }

        [Then(@"Vote count should be increased")]
        public void ThenVoteCountShouldBeIncreased()
        {
            Assert.IsTrue(trendingNowPage.isVoteCountIncreased());
        }
    }
}
