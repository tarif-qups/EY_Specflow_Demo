using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY_Specflow_Demo.Specs.Pages.SiteMapLinks
{
    public class NewsroomPage : PageObjectManager
    {
        IWebDriver driver;

        private By mediaInquiries = By.XPath("//h3[contains(text(), \"Media inquiries\")]");
        private By getInTouchBtn = By.XPath("(//a[contains(text(), \"Get in touch\")])[1]");
        private By getInTouchForm = By.XPath("(//div[@class=\"overlay-content\"])");

        public NewsroomPage(IWebDriver webDriver) : base(webDriver)
        {
            driver = webDriver;
        }

        public bool isMediaInquiriesVisible()
        {
            waitUntilElementIsVisible(mediaInquiries, 7);
            return isElementDisplayed(mediaInquiries);
        }

        public bool isGetInTouchVisible()
        {
            waitUntilElementIsVisible(getInTouchBtn, 7);
            return isElementDisplayed(getInTouchBtn);
        }

        public void clickGetInTouchBtn()
        {
            clickElement(getInTouchBtn);
        }

        public bool isGetInTouchFormVisible()
        {
            waitUntilElementIsVisible(getInTouchForm, 7);
            return isElementDisplayed(getInTouchForm);
        }

    }
}
