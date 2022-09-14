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
    public sealed class WebcastsPageSteps
    {
        WebcastsPage webcasts;

        public WebcastsPageSteps(SetDrivers drivers)
        {
            webcasts = new WebcastsPage(drivers.Current);
        }

        [Then(@"Webcasts link should be visible")]
        public void ThenWebcastsLinkShouldBeVisible()
        {
            Assert.IsTrue(webcasts.isWebcastsLinkVisible());
        }

        [When(@"User clicks on webcasts link")]
        public void WhenUserClicksOnWebcastsLink()
        {
            webcasts.clickWebcastsLink();
        }

        [Then(@"Webcasts page should be loaded")]
        public void ThenWebcastsPageShouldBeLoaded()
        {
            Assert.IsTrue(webcasts.getCurrentUrl().Contains("/webcasts"));
        }

        [Then(@"Webcasts list should be displayed")]
        public void ThenWebcastsListShouldBeDisplayed()
        {
            Assert.IsTrue(webcasts.isWebcastsListVisible());
        }

        [When(@"User clicks on details button for first webcast")]
        public void WhenUserClicksOnDetailsButtonForFirstWebcast()
        {
            webcasts.clickDetailBtn();
        }

        [Then(@"Webcasts details page should be loaded")]
        public void ThenWebcastsDetailsPageShouldBeLoaded()
        {
            Assert.IsTrue(webcasts.isDetailsPageLoaded());
        }

        [Then(@"Register button should be displayed")]
        public void ThenRegisterButtonShouldBeDisplayed()
        {
            Assert.IsTrue(webcasts.isRegisterButtonDisplayed());
        }

        [When(@"User clicks on Register button")]
        public void WhenUserClicksOnRegisterButton()
        {
            webcasts.clickRegisterBtn();
        }

        [Then(@"Register for form should be displayed")]
        public void ThenRegisterForFormShouldBeDisplayed()
        {
            Assert.IsTrue(webcasts.isRegisterFormDisplayed());
        }
    }
}
