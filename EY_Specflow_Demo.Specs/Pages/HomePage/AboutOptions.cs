using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY_Specflow_Demo.Specs.Pages.HomePage
{
    public class AboutOptions : PageObjectManager
    {
        IWebDriver driver;

        private By aboutOption = By.XPath("(//button[@class=\"main-navigation__l1-tab\"])[5]");
        private By aboutWrapper = By.XPath("//div[contains(text(), \"About us\")]");
        private By connectWithUsOption = By.XPath("//a[contains(text(), \"Connect with us\")]");
        private By connectForm = By.XPath("//div[@class=\"marketoForm component section default-style initialized\"]");
        private By ourPeopleOption = By.XPath("(//a[contains(text(), \"Our people\")])");

        public AboutOptions(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isAboutOptionVisible()
        {
            waitUntilElementIsVisible(aboutOption);
            return isElementDisplayed(aboutOption);
        }

        public void clickAboutOption()
        {
            clickElement(aboutOption);
        }

        public bool isAboutWrapperVisible()
        {
            waitUntilElementIsVisible(aboutWrapper);
            return isElementDisplayed(aboutWrapper);
        }

        public bool isConnectWithUsVisible()
        {
            return isElementDisplayed(connectWithUsOption);
        }

        public void clickConnectWithUsOption()
        {
            waitUntilElementIsClickable(connectWithUsOption);
            clickElement(connectWithUsOption);
        }

        public bool isConnectFormVisible()
        {
            waitUntilElementIsVisible(connectForm, 15);
            return isElementDisplayed(connectForm);
        }

        public bool isOurPeopleVisible()
        {
            return isElementDisplayed(ourPeopleOption);
        }

        public void clickOurPeopleUsOption()
        {
            waitUntilElementIsClickable(ourPeopleOption);
            clickElement(ourPeopleOption);
        }


    }
}
