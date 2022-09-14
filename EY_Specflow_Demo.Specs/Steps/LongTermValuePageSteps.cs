using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.InsightsOptionPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class LongTermValuePageSteps
    {
        LongTermValuePage longTermValuePage;
        public LongTermValuePageSteps(SetDrivers drivers)
        {
            longTermValuePage = new LongTermValuePage(drivers.Current);
        }

        [Then(@"Long-term value page should be loaded")]
        public void ThenLong_TermValuePageShouldBeLoaded()
        {
            Assert.IsTrue(longTermValuePage.getCurrentUrl().Contains("/long-term-value"));
        }
        [When(@"User scrolls down to EY value section")]
        public void WhenUserScrollsDownToEYValueSection()
        {
            longTermValuePage.scrollToEYValueSection();
        }
        [Then(@"EY value Realized section should be displayed")]
        public void ThenEYValueRealizedSectionShouldBeDisplayed()
        {
            Assert.IsTrue(longTermValuePage.isEyValueRealizedSectionVisible());
        }
        [Then(@"Explore button should be displayed")]
        public void ThenExploreButtonShouldBeDisplayed()
        {
            Assert.IsTrue(longTermValuePage.isExploreButtonDisplayed());
        }
        [When(@"User clicks Explore button")]
        public void WhenUserClicksExploreButton()
        {
            longTermValuePage.clickExploreButton();
        }
        [Then(@"EY Value Realized page should be loaded")]
        public void ThenEYValueRealizedPageShouldBeLoaded()
        {
            Assert.IsTrue(longTermValuePage.getCurrentUrl().Contains("value-realized"));
        }
        [When(@"User scrolls down to Show resources section")]
        public void WhenUserScrollsDownToShowResourcesSection()
        {
            longTermValuePage.scrollToShowResources();
        }
        [Then(@"Show resources section should be displayed")]
        public void ThenShowResourcesSectionShouldBeDisplayed()
        {
            Assert.IsTrue(longTermValuePage.isShowResourcesVisible());
        }
        [When(@"User clicks on show resources")]
        public void WhenUserClicksOnShowResources()
        {
            longTermValuePage.clickShowResourcesButton();
        }
        [Then(@"Report download option should be visible")]
        public void ThenReportDownloadOptionShouldBeVisible()
        {
            Assert.IsTrue(longTermValuePage.isDownloadOptionVisible());
        }
    }
}
