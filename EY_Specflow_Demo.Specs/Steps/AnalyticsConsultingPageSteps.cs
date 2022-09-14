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
    public sealed class AnalyticsConsultingPageSteps
    {
        AnalyticsConsultingPage consultingPage;
        public AnalyticsConsultingPageSteps(SetDrivers drivers)
        {
            consultingPage = new AnalyticsConsultingPage(drivers.Current);
        }

        [Then(@"Analytics Consulting Service page should loaded")]
        public void ThenAnalyticsConsultingServicePageShouldLoaded()
        {
            Assert.IsTrue(consultingPage.getCurrentUrl().Contains("analytics-consulting-services"));
        }

        [Then(@"Related topics section should be displayed")]
        public void ThenRelatedTopicsSectionShouldBeDisplayed()
        {
            Assert.IsTrue(consultingPage.isRelatedTopicsDisplayed());
        }

        [When(@"User clicks consulting button")]
        public void WhenUserClicksConsultingButton()
        {
            consultingPage.clickConsultingButton();
        }

        [Then(@"Consulting page should be loaded")]
        public void ThenConsultingPageShouldBeLoaded()
        {
            Assert.IsTrue(consultingPage.getCurrentUrl().Contains("/consulting"));
        }
    }
}
