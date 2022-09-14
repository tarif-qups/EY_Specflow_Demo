using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.IndustriesOptionPages
{
    public class ManufacturingPage : PageObjectManager
    {
        IWebDriver driver;

        private By electricVehicleArticle = By.XPath("//h4[contains(text(), \"electric vehicles\")]");
        private By twitterIcon = By.XPath("(//a[@title=\"Twitter\"])[2]");

        public ManufacturingPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isElectricVehicleArticleVisible()
        {
            waitUntilElementIsVisible(electricVehicleArticle);
            return isElementDisplayed(electricVehicleArticle);
        }

        public void clickElectricVehicleArticle()
        {
            clickElement(electricVehicleArticle);
        }

        public void scrollToTwitterIcon()
        {
            Thread.Sleep(3000);
            scrollToElement(twitterIcon);
        }

        public void clickTwitterIcon()
        {
            waitUntilElementIsClickable(twitterIcon);
            JavaScriptClick(twitterIcon);
        }

        public bool isTwitterPageOpened()
        {
            return isTabOpened("Twitter");
        }
    }
}
