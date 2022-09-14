using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.ServicesOptionPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class ServicesPageSteps
    {
        ServicesPage servicesPage;

        public ServicesPageSteps(SetDrivers drivers)
        {
            servicesPage = new ServicesPage(drivers.Current);
        }

        [Then(@"Services page should be loaded")]
        public void ThenServicesPageShouldBeLoaded()
        {
            Assert.IsTrue(servicesPage.getCurrentUrl().Contains("/services"));
        }

        [When(@"User scrolls down to Our alliances label")]
        public void WhenUserScrollsDownToOurAlliancesLabel()
        {
            servicesPage.scrollDownToOurAlliancesSection();
        }

        [Then(@"Our alliances section should be displayed")]
        public void ThenOurAlliancesSectionShouldBeDisplayed()
        {
            Assert.IsTrue(servicesPage.isOurAlliancesSectionDisplayed());
        }

        [Then(@"Find out more button should be visible")]
        public void ThenFindOutMoreButtonShouldBeVisible()
        {
            Assert.IsTrue(servicesPage.isOFindOutMoreButtonDisplayed());
        }

        [When(@"User clicks on Find out more button")]
        public void WhenUserClicksOnFindOutMoreButton()
        {
            servicesPage.clickFindOutMoreButton();
        }

        [Then(@"Alliances page should be loaded")]
        public void ThenAlliancesPageShouldBeLoaded()
        {
            Assert.IsTrue(servicesPage.getCurrentUrl().Contains("/alliances"));
        }

    }
}
