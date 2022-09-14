using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY_Specflow_Demo.Specs.Pages.SiteMapLinks
{
    public class EYEthicsPage : PageObjectManager
    {
        IWebDriver driver;

        private By codeOfConductLink = By.XPath("//a[contains(text(), \"Code of Conduct\")]");

        public EYEthicsPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isCodeOfConductVisible()
        {
            waitUntilElementIsVisible(codeOfConductLink, 7);
            return isElementDisplayed(codeOfConductLink);
        }

        public void clickCodeOfConducts()
        {
            clickElement(codeOfConductLink);
        }
    }
}
