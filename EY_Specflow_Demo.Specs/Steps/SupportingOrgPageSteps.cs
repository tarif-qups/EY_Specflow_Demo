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
    public sealed class SupportingOrgPageSteps
    {
        private SupportingOrgPage supportingOrg;

        public SupportingOrgPageSteps(SetDrivers drivers)
        {
            supportingOrg = new SupportingOrgPage(drivers.Current);
        }

        [When(@"User scrolls down to supporting organizations section")]
        public void WhenUserScrollsDownToSupportingOrganizationsSection()
        {
            supportingOrg.scrollToSupportingOrg();
        }

        [Then(@"Supporting organizations slider should displayed")]
        public void ThenSupportingOrganizationsSliderShouldDisplayed()
        {
            Assert.IsTrue(supportingOrg.isSupportingOrgDisplayed());
        }

        [When(@"User clicks on first slider")]
        public void WhenUserClicksOnFirstSlider()
        {
            supportingOrg.clickFirstSlider();
        }

        [Then(@"Selected topic page should be loaded")]
        public void ThenSelectedTopicPageShouldBeLoaded()
        {
            Assert.IsTrue(supportingOrg.isTopicPageLoaded());
        }
    }
}
