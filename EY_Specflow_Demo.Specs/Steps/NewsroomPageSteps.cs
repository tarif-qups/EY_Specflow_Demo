using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages.SiteMapLinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace EY_Specflow_Demo.Specs.Steps
{
    [Binding]
    public sealed class NewsroomPageSteps
    {
        NewsroomPage newsroomPage;

        public NewsroomPageSteps(SetDrivers drivers)
        {
            newsroomPage = new NewsroomPage(drivers.Current);
        }

        [Then(@"Media inquiries section should be visible")]
        public void ThenMediaInquiriesSectionShouldBeVisible()
        {
            Assert.IsTrue(newsroomPage.isMediaInquiriesVisible());
        }

        [Then(@"Get in touch button should be available")]
        public void ThenGetInTouchButtonShouldBeAvailable()
        {
            Assert.IsTrue(newsroomPage.isGetInTouchVisible());
        }

        [When(@"User clicks on Get in touch button")]
        public void WhenUserClicksOnGetInTouchButton()
        {
            newsroomPage.clickGetInTouchBtn();
        }

        [Then(@"Get in touch form should be visible")]
        public void ThenGetInTouchFormShouldBeVisible()
        {
            Assert.IsTrue(newsroomPage.isGetInTouchFormVisible());
        }

    }
}
