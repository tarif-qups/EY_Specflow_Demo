using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.InsightsOptionPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class TransformationPageSteps
    {
        TransformationPage transformationPage;

        public TransformationPageSteps(SetDrivers drivers)
        {
            transformationPage = new TransformationPage(drivers.Current);
        }

        [Then(@"Transformation page should be loaded")]
        public void ThenTransformationPageShouldBeLoaded()
        {
            Assert.IsTrue(transformationPage.getCurrentUrl().Contains("/transformation-realized"));
        }

        [When(@"User scrolls down to CEO agenda section")]
        public void WhenUserScrollsDownToCEOAgendaSection()
        {
            transformationPage.scrollDownToCEOAgendaSection();
        }

        [Then(@"CEO agenda section should be displayed")]
        public void ThenCEOAgendaSectionShouldBeDisplayed()
        {
            Assert.IsTrue(transformationPage.isCEOSectionDisplayed());
        }

        [Then(@"Discover more button should be displayed")]
        public void ThenDiscoverMoreButtonShouldBeDisplayed()
        {
            Assert.IsTrue(transformationPage.isDiscoverMoreButtonDisplayed());
        }

        [When(@"User clicks on Discover more button")]
        public void WhenUserClicksOnDiscoverMoreButton()
        {
            transformationPage.clickDiscoverMoreButton();
        }

        [Then(@"CEO agenda page should be loaded")]
        public void ThenCEOAgendaPageShouldBeLoaded()
        {
            Assert.IsTrue(transformationPage.getCurrentUrl().Contains("/ceo"));
        }

    }
}
