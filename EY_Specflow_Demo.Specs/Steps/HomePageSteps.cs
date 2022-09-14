using System;
using TechTalk.SpecFlow;
using EY_Specflow_Demo.Specs.Pages.HomePage;
using EY_Specflow_Demo.Specs.Drivers;
using NUnit.Framework;
[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public class HomePageSteps
    {
        private HomePage homePage;

        public HomePageSteps(SetDrivers drivers)
        {
            homePage = new HomePage(drivers.Current);
        }

        [Given(@"user enters the url")]
        public void UserEntersTheUrl()
        {
            Assert.AreEqual("https://www.ey.com/en_us", homePage.getCurrentUrl());
        }
        
        [Given(@"Welcome popup window should be displayed")]
        public void WelcomePopupWindowShouldBeDisplayed()
        {
            Assert.IsTrue(homePage.isCookiePopupDisplayed());
        }
        
        [When(@"user clicks I accept all cookies button")]
        public void UserClicksIAcceptAllCookiesButton()
        {
            homePage.clickAcceptPolicyButton();
        }
        
        [Then(@"home page should be displayed without popup")]
        public void HomePageShouldBeDisplayedWithoutPopup()
        {
            Assert.IsTrue(homePage.isHomepageDisplayedWithoutPopup());
        }

        [When(@"User scrolls down to the end")]
        public void WhenUserScrollsDownToTheEnd()
        {
            homePage.scrollToFooter();
        }

        [Then(@"Footer section should be visible")]
        public void ThenFooterSectionShouldBeVisible()
        {
            Assert.IsTrue(homePage.isFooterDisplayed());
        }
    }
}
