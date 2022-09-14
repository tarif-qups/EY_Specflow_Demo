using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.AboutOptionPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class OurPeopleOptionSteps
    {
        OurPeopleOptionPage peopleOptionPage;

        public OurPeopleOptionSteps(SetDrivers drivers)
        {
            peopleOptionPage = new OurPeopleOptionPage(drivers.Current);
        }

        [Then(@"Our people section should be displayed")]
        public void ThenOurPeopleSectionShouldBeDisplayed()
        {
            Assert.IsTrue(peopleOptionPage.isOurPeopleSectionVisible());
        }

        [When(@"User clicks Read more button in people section")]
        public void WhenUserClicksReadMoreButtonInPeopleSection()
        {
            peopleOptionPage.clickReadMoreButton();
        }

        [Then(@"More information about people should be displayed")]
        public void ThenMoreInformationAboutPeopleShouldBeDisplayed()
        {
            Assert.IsTrue(peopleOptionPage.isMoreInformationDisplayed());
        }

        [Then(@"EY Badges link should be displayed")]
        public void ThenEYBadgesLinkShouldBeDisplayed()
        {
            Assert.IsTrue(peopleOptionPage.isEYBadgeLinkVisible());
        }

        [When(@"User clicks on EY Badges link")]
        public void WhenUserClicksOnEYBadgesLink()
        {
            peopleOptionPage.clickEYBadgeLink();
        }

        [Then(@"Personalized career development page should be loaded")]
        public void ThenPersonalizedCareerDevelopmentPageShouldBeLoaded()
        {
            Assert.IsTrue(peopleOptionPage.getCurrentUrl().Contains("/personalized-career-development"));
        }

    }
}
