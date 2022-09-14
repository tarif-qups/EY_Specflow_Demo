using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.SiteMapLinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class EYEthicsPageSteps
    {
        EYEthicsPage ethicsPage;

        public EYEthicsPageSteps(SetDrivers drivers)
        {
            ethicsPage = new EYEthicsPage(drivers.Current);
        }

        [Then(@"Code of conduct link should be visible")]
        public void ThenCodeOfConductLinkShouldBeVisible()
        {
            Assert.IsTrue(ethicsPage.isCodeOfConductVisible());
        }

        [When(@"User clicks on Code of conduct link")]
        public void WhenUserClicksOnCodeOfConductLink()
        {
            ethicsPage.clickCodeOfConducts();
        }

        [Then(@"Global Code of conduct page should be loaded")]
        public void ThenGlobalCodeOfConductPageShouldBeLoaded()
        {
            Assert.IsTrue(ethicsPage.getCurrentUrl().Contains("/global-code-of-conduct"));
        }
    }
}
