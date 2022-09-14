using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.Footers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class LocationsPageSteps
    {
        private LocationsPage locationsPage;

        public LocationsPageSteps(SetDrivers drivers)
        {
            locationsPage = new LocationsPage(drivers.Current);
        }

        [Then(@"Our locations link should be visible")]
        public void ThenOurLocationsLinkShouldBeVisible()
        {
            Assert.IsTrue(locationsPage.isOurLocationVisible());
        }

        [When(@"User clicks on our locations link")]
        public void WhenUserClicksOnOurLocationsLink()
        {
            locationsPage.clickOurLocation();
        }

        [Then(@"Locations page should be loaded")]
        public void ThenLocationsPageShouldBeLoaded()
        {
            Assert.IsTrue(locationsPage.getCurrentUrl().Contains("/locations"));
        }

        [Then(@"Location search field should be visible")]
        public void ThenLocationSearchFieldShouldBeVisible()
        {
            Assert.IsTrue(locationsPage.isSearchFieldVisible());
        }

        [When(@"User enters ""(.*)"" in the location search field")]
        public void WhenUserEntersInTheLocationSearchField(string text)
        {
            locationsPage.enterSearchValue(text);
        }

        [Then(@"Location suggest list should be displayed")]
        public void ThenLocationSuggestListShouldBeDisplayed()
        {
            Assert.IsTrue(locationsPage.isResultListDisplayed());
        }

        [When(@"User clicks on California from the list")]
        public void WhenUserClicksOnCaliforniaFromTheList()
        {
            locationsPage.clickListItem();
        }

        [Then(@"California location page should be loaded")]
        public void ThenCaliforniaLocationPageShouldBeLoaded()
        {
            Assert.IsTrue(locationsPage.isSearchedLocationDisplayed());
        }

        [Then(@"Irvine location box should be displayed")]
        public void ThenIrvineLocationBoxShouldBeDisplayed()
        {
            Assert.IsTrue(locationsPage.isIrvineSectionDisplayed());
        }

        [When(@"User clicks on California")]
        public void WhenUserClicksOnCalifornia()
        {
            locationsPage.clickCaliforniaText();
        }

        [Then(@"Location details should be hidden")]
        public void ThenLocationDetailsShouldBeHidden()
        {
            Assert.IsTrue(locationsPage.isDetailsHidden());
        }

    }
}
