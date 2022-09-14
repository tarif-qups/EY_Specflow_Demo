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
    public sealed class GrowthStrategyPageSteps
    {
        GrowthStrategyPage growthStrategyPage;

        public GrowthStrategyPageSteps(SetDrivers drivers)
        {
            growthStrategyPage = new GrowthStrategyPage(drivers.Current);
        }

        [Then(@"Corporate and growth strategy page should be loaded")]
        public void ThenCorporateAndGrowthStrategyPageShouldBeLoaded()
        {
            Assert.IsTrue(growthStrategyPage.getCurrentUrl().Contains("/growth-strategy"));
        }

        [When(@"user scrolls down the growth strategy page")]
        public void WhenUserScrollsDownTheGrowthStrategyPage()
        {
            growthStrategyPage.scrollDownToHowEYParthenonCanHelp();
        }
        [Then(@"How EY-Parthenon can help section should be displayed")]
        public void ThenHowEY_ParthenonCanHelpSectionShouldBeDisplayed()
        {
            Assert.IsTrue(growthStrategyPage.isEYParthenonHelpSectionDisplayed());
        }
        [Then(@"How Digital strategy consulting section should be displayed")]
        public void ThenHowDigitalStrategyConsultingSectionShouldBeDisplayed()
        {
            Assert.IsTrue(growthStrategyPage.isDigitalStrategyConsultingDisplayed());
        }
        [When(@"user clicks on Digital strategy consulting link")]
        public void WhenUserClicksOnDigitalStrategyConsultingLink()
        {
            growthStrategyPage.clickDigitalStrategyConsulting();
        }
        [Then(@"Digital strategy consulting page should be loaded")]
        public void ThenDigitalStrategyConsultingPageShouldBeLoaded()
        {
            Assert.IsTrue(growthStrategyPage.getCurrentUrl().Contains("/digital-business-strategy-consulting"));
        }
        [When(@"user scrolls down the Digital strategy consulting page")]
        public void WhenUserScrollsDownTheDigitalStrategyConsultingPage()
        {
            growthStrategyPage.scrollToDigitalStrategyConsultingOption();
        }
        [When(@"user clicks on digital strategy consulting growth plus icon")]
        public void WhenUserClicksOnDigitalStrategyConsultingGrowthPlusIcon()
        {
            growthStrategyPage.clickDigitalStrategyConsultingOption();
        }
        [Then(@"digital strategy consulting growth details should be displayed")]
        public void ThenDigitalStrategyConsultingGrowthDetailsShouldBeDisplayed()
        {
            Assert.IsTrue(growthStrategyPage.isDigitalStrategyConsultingDetailsVisible());
        }
        [When(@"user scrolls down to consulting team section")]
        public void WhenUserScrollsDownToConsultingTeamSection()
        {
            growthStrategyPage.scrollToTeamSection();
        }
        [When(@"user clicks show more button")]
        public void WhenUserClicksShowMoreButton()
        {
            growthStrategyPage.clickShowMoreButton();
        }
        [Then(@"more team members should be displayed")]
        public void ThenMoreTeamMembersShouldBeDisplayed()
        {
            Assert.IsTrue(growthStrategyPage.isMoreTeamMemberDisplayed());
        }
    }
}
