using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.CareerOptionsPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class JobSearchPageSteps
    {
        JobSearchPage jobSearchPage;

        public JobSearchPageSteps(SetDrivers drivers)
        {
            jobSearchPage = new JobSearchPage(drivers.Current);
        }

        [Then(@"Job search page should be loaded")]
        public void ThenJobSearchPageShouldBeLoaded()
        {
            Assert.IsTrue(jobSearchPage.getCurrentUrl().Contains("/careers/job-search"));
        }

        [Then(@"Experienced professionals section should be visible")]
        public void ThenExperiencedProfessionalsSectionShouldBeVisible()
        {
            Assert.IsTrue(jobSearchPage.isExpProfessionalSectionVisible());
        }

        [When(@"user clicks on Search job link")]
        public void WhenUserClicksOnSearchJobLink()
        {
            jobSearchPage.clickSearchJobLink();
        }
        [Then(@"EY Jobs page should be loaded")]
        public void ThenEYJobsPageShouldBeLoaded()
        {
            Assert.IsTrue(jobSearchPage.getCurrentUrl().Contains("https://careers.ey.com/ey/search/"));
        }
        [Then(@"Search input field should be visible")]
        public void ThenSearchInputFieldShouldBeVisible()
        {
            Assert.IsTrue(jobSearchPage.isSearchInputFieldVisible());
        }
        [When(@"user inputs ""(.*)"" in the search field")]
        public void WhenUserInputsInTheSearchField(string text)
        {
            jobSearchPage.enterTextInSearchField(text);
        }
        [When(@"Clicks Search button")]
        public void WhenClicksSearchButton()
        {
            jobSearchPage.clickSearchButton();
        }
        [Then(@"Jobs list should be visible")]
        public void ThenJobsListShouldBeVisible()
        {
            Assert.IsTrue(jobSearchPage.isSearchResultDisplayed());
        }
        [When(@"user clicks on Clear button")]
        public void WhenUserClicksOnClearButton()
        {
            jobSearchPage.clickClearButton();
        }
        [Then(@"Search input field should be cleared")]
        public void ThenSearchInputFieldShouldBeCleared()
        {
            Assert.IsTrue(jobSearchPage.isSearchFieldCleared());
        }
        [Then(@"Project manager job should be visible")]
        public void ThenProjectManagerJobShouldBeVisible()
        {
            Assert.IsTrue(jobSearchPage.isProjectManagerVisible());
        }
        [When(@"user clicks on project manager")]
        public void WhenUserClicksOnProjectManager()
        {
            jobSearchPage.clickProjectManager();
        }
        [Then(@"Project manger job page should be loaded")]
        public void ThenProjectMangerJobPageShouldBeLoaded()
        {
            Assert.AreEqual(jobSearchPage.getProjectManagerJobPageTitle(), "Project Manager");
        }

    }
}
