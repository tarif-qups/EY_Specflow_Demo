using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.IndustriesOptionPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class ManufacturingPageSteps
    {
        ManufacturingPage manufacturingPage;

        public ManufacturingPageSteps(SetDrivers drivers)
        {
            manufacturingPage = new ManufacturingPage(drivers.Current);
        }

        [Then(@"Advanced manufacturing page should be loaded")]
        public void ThenAdvancedManufacturingPageShouldBeLoaded()
        {
            Assert.IsTrue(manufacturingPage.getCurrentUrl().Contains("/advanced-manufacturing"));
        }

        [Then(@"Article on Electric vehicle should be visible")]
        public void ThenArticleOnElectricVehicleShouldBeVisible()
        {
            Assert.IsTrue(manufacturingPage.isElectricVehicleArticleVisible());
        }

        [When(@"User clicks on the Article on Electric vehicle")]
        public void WhenUserClicksOnTheArticleOnElectricVehicle()
        {
            manufacturingPage.clickElectricVehicleArticle();
        }

        [Then(@"Article on Electric vehicle page should be loaded")]
        public void ThenArticleOnElectricVehiclePageShouldBeLoaded()
        {
            Assert.IsTrue(manufacturingPage.getCurrentUrl().Contains("mobility-consumer-index-wave-3"));
        }

        [When(@"User scrolls down to twitter icon")]
        public void WhenUserScrollsDownToTwitterIcon()
        {
            manufacturingPage.scrollToTwitterIcon();
        }

        [When(@"clicks Twitter icon")]
        public void WhenClicksTwitterIcon()
        {
            manufacturingPage.clickTwitterIcon();
        }

        [Then(@"Twitter page should be loaded on new tab")]
        public void ThenTwitterPageShouldBeLoadedOnNewTab()
        {
            Assert.IsTrue(manufacturingPage.isTwitterPageOpened());
        }

    }
}
