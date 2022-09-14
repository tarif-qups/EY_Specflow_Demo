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
    public sealed class CareerOptionSteps
    {
        CareerOption careerOption;

        public CareerOptionSteps(SetDrivers drivers)
        {
            careerOption = new CareerOption(drivers.Current);
        }

        [Given(@"Career Option is visible in the nav bar")]
        public void GivenCareerOptionIsVisibleInTheNavBar()
        {
            Assert.IsTrue(careerOption.isCareerOptionVisible());
        }

        [Given(@"user clicks on Career option")]
        public void GivenUserClicksOnCareerOption()
        {
            careerOption.clickCareerOption();
        }

        [Then(@"Career option wrapper should be visible")]
        public void ThenCareerOptionWrapperShouldBeVisible()
        {
            Assert.IsTrue(careerOption.isCareerWrapperVisible());
        }

        [Then(@"Job Search option should be visible")]
        public void ThenJobSearchOptionShouldBeVisible()
        {
            Assert.IsTrue(careerOption.isJobSearchOptionVisible());
        }

        [When(@"user clicks on Job search option")]
        public void WhenUserClicksOnJobSearchOption()
        {
            careerOption.clickJobSearchOption();
        }

        [Then(@"Explore button should be visible under Career section")]
        public void ThenExploreButtonShouldBeVisibleUnderCareerSection()
        {
            Assert.IsTrue(careerOption.isExploreButtonDisplayed());
        }

        [When(@"User clicks on Explore button from Career section")]
        public void WhenUserClicksOnExploreButtonFromCareerSection()
        {
            careerOption.clickExploreButton();
        }

    }
}
