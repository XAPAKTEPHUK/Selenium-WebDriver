using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PetCareTests.Pages
{
    public class ContactMePage
    {

        private IWebDriver driver;
        public ContactMePage(IWebDriver outsideDriver)
        {
            driver = outsideDriver;
        }
        private IWebElement ContactPageMenuItem => driver.FindElement(By.LinkText("Contact"));
        private IWebElement ContactPageHeader => driver.FindElement(By.ClassName("title"));
        private IWebElement ContactPageText => driver.FindElement(By.XPath("//p[contains(.,'If you want')]"));
        private IWebElement ContactPagePhone => driver.FindElement(By.XPath("//div[@class='contact']//ul//li[2]"));
        private IWebElement ContactPageEmail => driver.FindElement(By.XPath("//a[.='vova64@gmail.com']"));
        private IWebElement SubmitCareRequest => driver.FindElement(By.LinkText("care request"));
        private IWebElement CareRequestPageTitle => driver.FindElement(By.TagName("h1"));

        public void OpenContactPage()
        {
            ContactPageMenuItem.Click();
        }

        public string GeContactPagetHeaderText()
        {
            return ContactPageHeader.Text;
        }

        public string GetPageText()
        {
            return ContactPageText.Text;
        }
        public string GetPagePhone()
        {
            return ContactPagePhone.Text;
        }
        public string GetPageEmail()
        {
            return ContactPageEmail.Text;
        }
        public void OpenCareRequestPage()
        {
            SubmitCareRequest.Click();
        }
        public string GetCareRequestTitle()
        {
            return CareRequestPageTitle.Text;
        }
    }

}
