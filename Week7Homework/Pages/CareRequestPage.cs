using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PetCareTests.TestData;

namespace PetCareTests.Pages
{
    public class CareRequestPage
    {
        private IWebDriver _driver;
        public CareRequestPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement CareRequestPageHeader => _driver.FindElement(By.TagName("h1"));
        private IWebElement FirstNameInput => _driver.FindElement(By.Id("firstName"));
        private IWebElement LastNameInput => _driver.FindElement(By.Name("lastName"));
        private IWebElement PhoneNumberInput => _driver.FindElement(By.ClassName("phoneNumber"));
        private IWebElement EmailInput => _driver.FindElement(By.XPath("//div[@id='emailContainer']/input"));
        private IWebElement CatCheckbox => _driver.FindElement(By.Id("cat"));
        private SelectElement CatQuantityDropdown => new SelectElement(_driver.FindElement(By.Id("catQuantity")));
        private IWebElement OtherCheckbox => _driver.FindElement(By.Id("other"));
        private SelectElement OtherQuantityDropdown => new SelectElement(_driver.FindElement(By.Id("otherQuantity")));
        private IWebElement OneVisitPerDayRadio => _driver.FindElement(By.Id("visitOneTimePerDay"));
        private IWebElement SeveralVisitsPerDayRadio => _driver.FindElement(By.Id("visitSeveralTimesPerDay"));
        private SelectElement VisitsPerDayDropdown => new SelectElement(_driver.FindElement(By.Id("visitsPerDay")));
        private IWebElement CommentsTextArea => _driver.FindElement(By.Id("comments"));
        private IWebElement SendRequestButton => _driver.FindElement(By.Id("requestButton"));

        public void FillOutContactInformation(Person person)
        {
            FirstNameInput.SendKeys(person.FirstName);
            LastNameInput.SendKeys(person.LastName);
            PhoneNumberInput.SendKeys(person.PhoneNumber);
            EmailInput.SendKeys(person.Email);
        }

        public void RequestCatCare(string numberOfCats)
        {
            CatCheckbox.Click();
            CatQuantityDropdown.SelectByText(numberOfCats);
        }

        public void RequestOtherCare(string numberOfOthers)
        {
            OtherCheckbox.Click();
            OtherQuantityDropdown.SelectByText(numberOfOthers);
        }

        public void SetVisitsPerDay(int numberOfVisits)
        {
            if (numberOfVisits == 1)
            {
                OneVisitPerDayRadio.Click();
            }
            else
            {
                SeveralVisitsPerDayRadio.Click();
                VisitsPerDayDropdown.SelectByText(numberOfVisits.ToString());
            }
        }

        public void FillOutComments(string comment)
        {
            CommentsTextArea.SendKeys(comment);
        }

        public void ClickRequestButton()
        {
            SendRequestButton.Click();
        }

    }
}