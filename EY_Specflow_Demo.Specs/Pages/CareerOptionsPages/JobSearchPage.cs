using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EY_Specflow_Demo.Specs.Pages.CareerOptionsPages
{
    public class JobSearchPage : PageObjectManager
    {
        IWebDriver driver;

        private By experiencedProfessionals = By.XPath("//h3[contains(text(), \"Experienced professionals\")]");
        private By searchJobLink = By.XPath("//u[contains(text(), \"Search jobs\")]");
        private By searchInputField = By.XPath("(//input[@type=\"text\"])[1]");
        private By searchButton = By.XPath("(//input[@type=\"submit\"])[1]");
        private By searchResultsTable = By.XPath("//table[@id=\"searchresults\"]");
        private By clearButton = By.XPath("//a[contains(text(), \"Clear\")]");
        private By projectManagerJobLink = By.XPath("//a[@class=\"jobTitle-link\"]");

        public JobSearchPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }



        public bool isExpProfessionalSectionVisible()
        {
            waitUntilElementIsVisible(experiencedProfessionals);
            return isElementDisplayed(experiencedProfessionals);
        }

        public void clickSearchJobLink()
        {
            JavaScriptClick(searchJobLink);
        }

        public bool isSearchInputFieldVisible()
        {
            waitUntilElementIsVisible(searchInputField);
            return isElementDisplayed(searchInputField);
        }

        public void enterTextInSearchField(String text)
        {
            SendKeysToElement(searchInputField, text);
        }

        public void clickSearchButton()
        {
            waitUntilElementIsClickable(searchButton);
            clickElement(searchButton);
        }

        public bool isSearchResultDisplayed()
        {
            waitUntilElementIsVisible(searchResultsTable);
            return isElementDisplayed(searchResultsTable);
        }

        public void clickClearButton()
        {
            clickElement(clearButton);
        }

        public bool isSearchFieldCleared()
        {
            if (driver.FindElement(searchInputField).GetAttribute("value") == "")
            {
                return true;
            }
            else return false;
        }

        public bool isProjectManagerVisible()
        {
            return isElementDisplayed(projectManagerJobLink);
        }

        public void clickProjectManager()
        {
            IList<IWebElement> elements = GetWebElements(projectManagerJobLink);
            foreach (IWebElement element in elements)
            {
                String title = element.Text;
                if (title.Equals("Project Manager"))
                {
                    Thread.Sleep(3000);
                    JavaScriptClickElement(element);
                    break;
                }
            }
        }

        public String getProjectManagerJobPageTitle()
        {
            return driver.Title;
        }
    }
}
