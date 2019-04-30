using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Shouldly;


namespace PetCareTests
{
    [TestFixture]
    public class CareRequestTest
    {
        [Test]
        public void CareTest()
        {
            var testPhoneNumber = "7733969481";
            var testEmail = "lemeha.iryna@gmail.com";
            var firstNameValue = "iryna";
            var lastNameValue = "Lemeha";
            
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                driver.FindElement(By.LinkText("Care Request")).Click();
                //Fill out the form
                IWebElement firstName = driver.FindElement(By.Id("firstName"));
                firstName.SendKeys(firstNameValue);
                IWebElement lastName = driver.FindElement(By.Name("lastName"));

                lastName.SendKeys(lastNameValue);
                var phoneNumber = driver.FindElement(By.ClassName("phoneNumber"));
                phoneNumber.SendKeys(testPhoneNumber);
                var email = driver.FindElement(By.XPath("//div[@id='emailContainer']//input"));
                email.SendKeys(testEmail);

                //Choose a pet by checking checkbox
                var petCheckbox = driver.FindElement(By.Id("dog"));
                petCheckbox.Click();

                //Choose amount of pets in the dropdown
                IWebElement dogAmountSelect = driver.FindElement(By.Id("dogQuantity"));
                SelectElement dogAmount = new SelectElement(dogAmountSelect);
                dogAmount.SelectByText("3+");

                //Choose number of visit per day
                var daysTotal = driver.FindElement(By.Id("visitSeveralTimesPerDay"));
                daysTotal.Click();

                //Choose how many times per day
                var timesPerDay = new SelectElement(driver.FindElement(By.Id("visitsPerDay")));
                timesPerDay.SelectByText("4");

                //Type additionl comments
                var yourComments = driver.FindElement(By.Id("comments"));
                yourComments.SendKeys("I would like to hire a person for 1-2 years.");

                //Submit your request
                var requestButton = driver.FindElement(By.Id("requestButton"));
                requestButton.Click();

                Thread.Sleep(1000);

                var closeButton = driver.FindElementByXPath("//button[.='Close']");
                var modal = driver.FindElement(By.ClassName("modal-body"));
                var modalText = modal.Text;
                Console.WriteLine(modalText);
                modalText.ShouldContain($"Phone #: {testPhoneNumber}");
                modalText.ShouldContain($"Email: {testEmail}");
                modalText.ShouldContain($"First Name: {firstNameValue}");
                modalText.ShouldContain($"Last Name: {lastNameValue}");

                closeButton.Click();
            }
        }
    }
}
