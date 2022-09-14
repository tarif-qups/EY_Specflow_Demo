using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.Footers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class SiteMapPageSteps
    {
        SiteMapPage siteMapPage;
        public SiteMapPageSteps(SetDrivers drivers)
        {
            siteMapPage = new SiteMapPage(drivers.Current);
        }

        [Then(@"Site map link should be visible")]
        public void ThenSiteMapLinkShouldBeVisible()
        {
            Assert.IsTrue(siteMapPage.isSiteMapLinkVisible());
        }

        [When(@"User clicks on Site map link")]
        public void WhenUserClicksOnSiteMapLink()
        {
            siteMapPage.clickSiteMapLink();
        }

        [Then(@"Site map page should be loaded")]
        public void ThenSiteMapPageShouldBeLoaded()
        {
            Assert.IsTrue(siteMapPage.getCurrentUrl().Contains("/sitemap"));
        }

        [Then(@"Legal section should be displayed")]
        public void ThenLegalSectionShouldBeDisplayed()
        {
            Assert.IsTrue(siteMapPage.isLegalSectionVisible());
        }

        [Then(@"EY Ethics Hotline link should be displayed")]
        public void ThenEYEthicsHotlineLinkShouldBeDisplayed()
        {
            Assert.IsTrue(siteMapPage.isEYEthicsLinkVisible());
        }

        [When(@"User clicks on EY Ethics Hotline link")]
        public void WhenUserClicksOnEYEthicsHotlineLink()
        {
            siteMapPage.clickEYEthicsLink();
        }

        [Then(@"EY Ethics Hotline page should be loaded")]
        public void ThenEYEthicsHotlinePageShouldBeLoaded()
        {
            Assert.IsTrue(siteMapPage.getCurrentUrl().Contains("/ey-ethics-hotline"));
        }

        [Then(@"News section should be displayed")]
        public void ThenNewsSectionShouldBeDisplayed()
        {
            Assert.IsTrue(siteMapPage.isNewsSectionVisible());
        }

        [Then(@"Press releases link should be displayed")]
        public void ThenPressReleasesLinkShouldBeDisplayed()
        {
            Assert.IsTrue(siteMapPage.isPressReleasesVisible());
        }

        [When(@"User clicks on Press Releases link")]
        public void WhenUserClicksOnPressReleasesLink()
        {
            siteMapPage.clickPressReleasesLink();
        }

        [Then(@"Newsroom page should be loaded")]
        public void ThenNewsroomPageShouldBeLoaded()
        {
            Assert.IsTrue(siteMapPage.getCurrentUrl().Contains("/newsroom"));
        }
    }
}
