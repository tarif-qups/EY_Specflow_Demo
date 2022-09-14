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
    public sealed class ServicesOptionSteps
    {
        ServicesOptions servicesOption;

        public ServicesOptionSteps(SetDrivers drivers)
        {
            servicesOption = new ServicesOptions(drivers.Current);
        }
        [Given(@"Services option is visible in the nav bar")]
        public void GivenServicesOptionIsVisibleInTheNavBar()
        {
            Assert.IsTrue(servicesOption.isServicesOptionVisible());
        }
        [Given(@"User clicks Services option")]
        public void GivenUserClicksServicesOption()
        {
            servicesOption.clickServicesOption();
        }
        [Then(@"Services wrapper should be displayed")]
        public void ThenServicesWrapperShouldBeDisplayed()
        {
            Assert.IsTrue(servicesOption.isServicesWrapperDisplayed());
        }
        [Then(@"Spotlight should be displayed")]
        public void ThenSpotlightShouldBeDisplayed()
        {
            Assert.IsTrue(servicesOption.isSpotlightDisplayed());
        }
        [When(@"user clicks on Strategy by EY-Parthenon option")]
        public void WhenUserClicksOnStrategyByEY_ParthenonOption()
        {
            servicesOption.clickStrategyByEYParthenonOption();
        }
        [Then(@"Strategy by EY-Parthenon list should be displayed")]
        public void ThenStrategyByEY_ParthenonListShouldBeDisplayed()
        {
            Assert.IsTrue(servicesOption.isStrategyByEYParthenonListDisplayed());
        }
        [When(@"user clicks on Corporate and growth option")]
        public void WhenUserClicksOnCorporateAndGrowthOption()
        {
            servicesOption.clickCorporateAndGrowthOption();
        }

        [Then(@"Consulting option should be displayed")]
        public void ThenConsultingOptionShouldBeDisplayed()
        {
            Assert.IsTrue(servicesOption.isConsultingDisplayed());
        }

        [When(@"user clicks on Consulting option")]
        public void WhenUserClicksOnConsultingOption()
        {
            servicesOption.clickConsultingOption();
        }

        [Then(@"Analytics Consulting Service option should be visible")]
        public void ThenAnalyticsConsultingServiceOptionShouldBeVisible()
        {
            Assert.IsTrue(servicesOption.isAnalyticsConsultingDisplayed());
        }

        [When(@"User clicks on Analytics Consulting Service")]
        public void WhenUserClicksOnAnalyticsConsultingService()
        {
            servicesOption.clickAnalyticsConsultingOption();
        }

        [Then(@"Explore button should be visible under Services section")]
        public void ThenExploreButtonShouldBeVisibleUnderServicesSection()
        {
            Assert.IsTrue(servicesOption.isExploreButtonDisplayed());
        }

        [When(@"User clicks on Explore button from Services section")]
        public void WhenUserClicksOnExploreButtonFromServicesSection()
        {
            servicesOption.clickExploreOption();
        }

    }
}
