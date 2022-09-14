using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.IndustriesOptionPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class IndustryPageSteps
    {
        IndustriesReimaginedPage industriesPage;

        public IndustryPageSteps(SetDrivers drivers )
        {
            industriesPage = new IndustriesReimaginedPage(drivers.Current);
        }

        [Then(@"Industry reimagined page should be loaded")]
        public void ThenIndustryReimaginedPageShouldBeLoaded()
        {
            Assert.IsTrue(industriesPage.getCurrentUrl().Contains("industry-reimagined"));
        }

        [When(@"User scrolls down to Related industry section")]
        public void WhenUserScrollsDownToRelatedIndustrySection()
        {
            industriesPage.scrollDownToRelatedIndustrySection();
        }

        [Then(@"Related industry section should be displayed")]
        public void ThenRelatedIndustrySectionShouldBeDisplayed()
        {
            Assert.IsTrue(industriesPage.isRelatedIndustrySectionDisplayed());
        }

        [Then(@"Automotive option should be displayed")]
        public void ThenAutomotiveOptionShouldBeDisplayed()
        {
            Assert.IsTrue(industriesPage.isAutomotiveOptionDisplayed());
        }

        [When(@"User clicks Automotive option")]
        public void WhenUserClicksAutomotiveOption()
        {
            industriesPage.clickAutomotiveOptionButton();
        }

        [Then(@"Automotive page should be loaded")]
        public void ThenAutomotivePageShouldBeLoaded()
        {
            Assert.IsTrue(industriesPage.getCurrentUrl().Contains("automotive-transportation"));
        }

    }
}
