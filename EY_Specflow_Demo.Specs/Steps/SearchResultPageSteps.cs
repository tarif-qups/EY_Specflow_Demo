using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.HomePage;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public class SearchResultPageSteps
    {
        private SearchResultPage searchResult;

        public SearchResultPageSteps(SetDrivers driver)
        {
            searchResult = new SearchResultPage(driver.Current);
        }
        
        [Then(@"Search button should be visible in the nav bar")]
        public void SearchButtonShouldBeVisibleInTheNavBar()
        {
            Assert.IsTrue(searchResult.isSearchButtonVisible());
        }

        [When(@"user clicks on search button")]
        public void UserClicksOnSearchButton()
        {
            searchResult.clickSearchButton();
        }

        [Then(@"Search input field should be displayed")]
        public void SearchInputFieldShouldBeDisplayed()
        {
            Assert.IsTrue(searchResult.isSearchInputFieldVisible());
        }

        [Then(@"Trending Section should be displayed")]
        public void TrendingSectionShouldBeDisplayed()
        {
            Assert.IsTrue(searchResult.isTrendingSectionVisible());
        }

        [When(@"User inserts ""(.*)"" in the input field")]
        public void UserInsertsInTheInputField(string text)
        {
            searchResult.insertInput(text);
        }

        [Then(@"Topic section should be displayed")]
        public void TopicSectionShouldBeDisplayed()
        {
            Assert.IsTrue(searchResult.isTopicSectionVisible());
        }


        [Then(@"General section should be displayed")]
        public void GeneralSectionShouldBeDisplayed()
        {
            Assert.IsTrue(searchResult.isGeneralSectionVisible());
        }
        
        [Then(@"People section should be displayed")]
        public void PeopleSectionShouldBeDisplayed()
        {
            Assert.IsTrue(searchResult.isPeopleSectionVisible());
        }
        
        [When(@"user presses enter")]
        public void UserPressesEnter()
        {
            searchResult.pressEnter();
        }

        [Then(@"Search results page should be loaded")]
        public void SearchResultsPageShouldBeLoaded()
        {
            Thread.Sleep(3000);
            Console.WriteLine(searchResult.getCurrentUrl());
            Assert.IsTrue(searchResult.getCurrentUrl().Contains("/search?q=Career"));
        }

        [Then(@"Sorting options should be visible")]
        public void SortingOptionsShouldBeVisible()
        {
            Assert.IsTrue(searchResult.isSortingOptionVisible());
        }

        [Then(@"Filtering options should be visible")]
        public void FilteringOptionsShouldBeVisible()
        {
            Assert.IsTrue(searchResult.isFilterVisible());
        }

        [When(@"User clicks About checkbox from filters options")]
        public void UserClicksAboutCheckboxFromFiltersOptions()
        {
            searchResult.clickAboutCheckbox();
        }
        
        [Then(@"Filtered topics should be displayed")]
        public void FilteredTopicsShouldBeDisplayed()
        {
            Assert.IsTrue(searchResult.isPageFiltered());
        }
    }
}
