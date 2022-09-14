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
    public sealed class AboutOptionsSteps
    {
        AboutOptions aboutOptions;

        public AboutOptionsSteps(SetDrivers drivers)
        {
            aboutOptions = new AboutOptions(drivers.Current);
        }

        [Given(@"About option is available in the nav bar")]
        public void GivenAboutOptionIsAvailableInTheNavBar()
        {
            Assert.IsTrue(aboutOptions.isAboutOptionVisible());
        }

        [Given(@"User clicks About option")]
        public void GivenUserClicksAboutOption()
        {
            aboutOptions.clickAboutOption();
        }

        [Then(@"About wrapper should be visible")]
        public void ThenAboutWrapperShouldBeVisible()
        {
            Assert.IsTrue(aboutOptions.isAboutWrapperVisible());
        }

        [Then(@"Contact with us option should be visible")]
        public void ThenContactWithUsOptionShouldBeVisible()
        {
            Assert.IsTrue(aboutOptions.isConnectWithUsVisible());
        }

        [When(@"user clicks on Contact with us option")]
        public void WhenUserClicksOnContactWithUsOption()
        {
            aboutOptions.clickConnectWithUsOption();
        }

        [Then(@"Contact form should be loaded")]
        public void ThenContactFormShouldBeLoaded()
        {
            Assert.IsTrue(aboutOptions.isConnectFormVisible());
        }

        [Then(@"Our people option should be visible")]
        public void ThenOurPeopleOptionShouldBeVisible()
        {
            Assert.IsTrue(aboutOptions.isOurPeopleVisible());
        }

        [When(@"User clicks on Our people option")]
        public void WhenUserClicksOnOurPeopleOption()
        {
            aboutOptions.clickOurPeopleUsOption();
        }

    }
}
