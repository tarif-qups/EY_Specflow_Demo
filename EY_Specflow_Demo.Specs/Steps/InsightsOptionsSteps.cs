using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class InsightsOptionsSteps
    {
        InsightsOptions insightsOption;

        public InsightsOptionsSteps(SetDrivers drivers)
        {
            insightsOption = new InsightsOptions(drivers.Current);
        }

        [Given(@"Insights option is available at nav bar")]
        public void GivenInsightsOptionIsAvailableAtNavBar()
        {
            Assert.IsTrue(insightsOption.isInsightOptionAvailable());
        }

        [Given(@"User clicks Insights option")]
        public void GivenUserClicksInsightsOption()
        {
            insightsOption.clickInsightOption();
        }

        [Then(@"Trending Topics should be displayed")]
        public void ThenTrendingTopicsShouldBeDisplayed()
        {
            Assert.IsTrue(insightsOption.isTrendingTopicVisible());
        }

        [Then(@"C-suite agendas should be displayed")]
        public void ThenC_SuiteAgendasShouldBeDisplayed()
        {
            Assert.IsTrue(insightsOption.isCSuiteVisible());
        }

        [When(@"User clicks Technology option")]
        public void WhenUserClicksTechnologyOption()
        {
            insightsOption.clickTechnologyOption();
        }

        [Then(@"Insights wrapper should be displayed")]
        public void ThenInsightsWrapperShouldBeDisplayed()
        {
            Assert.IsTrue(insightsOption.isInsightsWrapperVisible());
        }

        [Then(@"Transformation option should be displayed")]
        public void ThenTransformationOptionShouldBeDisplayed()
        {
            Assert.IsTrue(insightsOption.isTransformationOptionVisible());
        }

        [When(@"User clicks on Transformation option")]
        public void WhenUserClicksOnTransformationOption()
        {
            insightsOption.clickTransformationOption();
        }

        [Then(@"Long-term value option should be displayed")]
        public void ThenLong_TermValueOptionShouldBeDisplayed()
        {
            Assert.IsTrue(insightsOption.isLongTermValueOptionVisible());
        }

        [When(@"User clicks on Long-term value option")]
        public void WhenUserClicksOnLong_TermValueOption()
        {
            insightsOption.clickLongTermValueOption();
        }

    }
}
