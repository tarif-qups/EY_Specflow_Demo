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
    public sealed class IndustriesOptionSteps
    {
        IndustriesOptions industriesOption;

        public IndustriesOptionSteps(SetDrivers drivers)
        {
            industriesOption = new IndustriesOptions(drivers.Current);
        }

        [Given(@"Industries option is visible in the nav bar")]
        public void GivenIndustriesOptionIsVisibleInTheNavBar()
        {
            Assert.IsTrue(industriesOption.isIndustriesOptionVisible());
        }

        [Given(@"User clicks Industries option")]
        public void GivenUserClicksIndustriesOption()
        {
            industriesOption.clickIndustriesOption();
        }

        [Then(@"Industries wrapper should be visible")]
        public void ThenIndustriesWrapperShouldBeVisible()
        {
            Assert.IsTrue(industriesOption.isIndustriesWrapperDisplayed());
        }

        [Then(@"Case Studies text should be visible")]
        public void ThenCaseStudiesTextShouldBeVisible()
        {
            Assert.IsTrue(industriesOption.isCaseStudiesDisplayed());
        }

        [Then(@"Advanced Manufacturing option should be visible")]
        public void ThenAdvancedManufacturingOptionShouldBeVisible()
        {
            Assert.IsTrue(industriesOption.isAdvancedManufacturingDisplayed());
        }

        [When(@"user clicks Advanced Manufacturing option")]
        public void WhenUserClicksAdvancedManufacturingOption()
        {
            industriesOption.clickAdvancedManufacturing();
        }

        [Then(@"Explore button should be visible under Industry section")]
        public void ThenExploreButtonShouldBeVisibleUnderIndustrySection()
        {
            Assert.IsTrue(industriesOption.isExploreButtonDisplayed());
        }

        [When(@"User clicks on Explore button from Industry section")]
        public void WhenUserClicksOnExploreButtonFromIndustrySection()
        {
            industriesOption.clickExploreButton();
        }

    }
}
