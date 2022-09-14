using BoDi;
using EY_Specflow_Demo.Specs.Drivers;
using EY_Specflow_Demo.Specs.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EY_Specflow_Demo.Specs.Hooks
{
    [Binding]
    public sealed class BrowserHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer objectContainer)
        {
            objectContainer.BaseContainer.Resolve<SetDrivers>();
        }

        [BeforeScenario("EY")]
        public void BeforeScenario(SetDrivers drivers)
        {
            var pageObjects = new PageObjectManager(drivers.Current);
            pageObjects.loadUrl();
        }

        [AfterScenario]
        public void AfterScenario(SetDrivers drivers)
        {
            var pageObjects = new PageObjectManager(drivers.Current);
            pageObjects.tearDown();
        }
    }
}
