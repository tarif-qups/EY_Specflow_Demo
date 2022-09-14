using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.InsightsOptionPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class TechnologySteps
    {
        TechnologyPage technologyPage;

        public TechnologySteps(SetDrivers drivers)
        {
            technologyPage = new TechnologyPage(drivers.Current);
        }

        [Then(@"Technology page should be loaded")]
        public void ThenTechnologyPageShouldBeLoaded()
        {
            Assert.IsTrue(technologyPage.getCurrentUrl().Contains("/technology"));
        }

        [When(@"User clicks Read more button")]
        public void WhenUserClicksReadMoreButton()
        {
            technologyPage.clickReadMoreButton();
        }

        [Then(@"More information should be displayed")]
        public void ThenMoreInformationShouldBeDisplayed()
        {
            Assert.IsTrue(technologyPage.isMoreInformationDisplayed());
        }

        [When(@"User scrolls down to Our Latest Thinking article")]
        public void WhenUserScrollsDownToOurLatestThinkingArticle()
        {
            technologyPage.scrollDownTechnologyPage();
        }

        [Then(@"Our Latest Thinking article should be displayed")]
        public void ThenOurLatestThinkingArticleShouldBeDisplayed()
        {
            Assert.IsTrue(technologyPage.isOurLatestThinkContainerVisible());
        }

        [Then(@"article title image box should be displayed")]
        public void ThenArticleTitleImageBoxShouldBeDisplayed()
        {
            Assert.IsTrue(technologyPage.isArticleTitleImageDisplayed());
        }

        [When(@"User clicks on the article image")]
        public void WhenUserClicksOnTheArticleImage()
        {
            technologyPage.clickArticleImage();
        }

        [Then(@"Article page should be loaded")]
        public void ThenArticlePageShouldBeLoaded()
        {
            Assert.IsTrue(technologyPage.getCurrentUrl().Contains("webcasts/"));
        }

        [When(@"User scrolls down the article page")]
        public void WhenUserScrollsDownTheArticlePage()
        {
            technologyPage.scrollDownArticlePage();
        }

        [Then(@"Show references icons should be displayed")]
        public void ThenShowReferencesIconsShouldBeDisplayed()
        {
            Assert.IsTrue(technologyPage.isShowReferencesTextDisplayed());
        }

        [When(@"User clicks on Facebook icon")]
        public void WhenUserClicksOnFacebookIcon()
        {
            technologyPage.clickFacebookIcon();
        }

        [Then(@"Facebook page should be loaded on new tab")]
        public void ThenFacebookPageShouldBeLoadedOnNewTab()
        {
            Assert.IsTrue(technologyPage.isFacebookPageLoaded());
        }

    }
}
