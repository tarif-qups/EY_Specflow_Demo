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
    public sealed class HowToApplyPageSteps
    {
        HowToApplyPage howToApplyPage;

        public HowToApplyPageSteps(SetDrivers drivers)
        {
            howToApplyPage = new HowToApplyPage(drivers.Current);
        }

        [Then(@"Career at EY page should be loaded")]
        public void ThenCareerAtEYPageShouldBeLoaded()
        {
            Assert.IsTrue(howToApplyPage.getCurrentUrl().Contains("careers"));
        }

        [When(@"User scrolls down to Students section")]
        public void WhenUserScrollsDownToStudentsSection()
        {
            howToApplyPage.scrollToStudentsSection();
        }

        [Then(@"How to apply button should be displayed")]
        public void ThenHowToApplyButtonShouldBeDisplayed()
        {
            Assert.IsTrue(howToApplyPage.isHowToApplyBtnVisible());
        }

        [When(@"User clicks on How to apply button")]
        public void WhenUserClicksOnHowToApplyButton()
        {
            howToApplyPage.clickHowToApplyBtn();
        }

        [Then(@"How to apply page should be loaded")]
        public void ThenHowToApplyPageShouldBeLoaded()
        {
            Assert.IsTrue(howToApplyPage.getCurrentUrl().Contains("how-to-apply"));
        }

        [Then(@"Hiring process for students should be displayed")]
        public void ThenHiringProcessForStudentsShouldBeDisplayed()
        {
            Assert.IsTrue(howToApplyPage.isHiringProcessSectionDisplayed());
        }

        [When(@"User scrolls down to processes")]
        public void WhenUserScrollsDownToProcesses()
        {
            howToApplyPage.scrollToProcesses();
        }

        [Then(@"Process steps should be displayed")]
        public void ThenProcessStepsShouldBeDisplayed()
        {
            Assert.IsTrue(howToApplyPage.isStepDisplayed());
        }

        [When(@"User clicks on step one")]
        public void WhenUserClicksOnStepOne()
        {
            howToApplyPage.clickStepOne();
        }

        [Then(@"Step details should be displayed")]
        public void ThenStepDetailsShouldBeDisplayed()
        {
            Assert.IsTrue(howToApplyPage.areDetailsDisplayed());
        }

    }
}
