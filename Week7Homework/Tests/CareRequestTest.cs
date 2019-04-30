using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PetCareTest.Pages;
using PetCareTest.TestData;
using PetCareTests.Pages;
using Shouldly;


namespace PetCareTests
{
    [TestFixture]
    public class CareRequestTest
    {
        [Test]
        public void CareRequestPageTest()
        {
            var person = new Person();
            person.SeedRandomData();


            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                var navigationMenuPage = new NavigationMenuPage(driver);
                navigationMenuPage.OpenCareRequestPage();

                var careRequestPage = new CareRequestPage(driver);
                careRequestPage.FillOutContactInformation(person);

                careRequestPage.RequestCatCare("3");

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
                modalText.ShouldContain($"Phone #: {person.PhoneNumber}");
                modalText.ShouldContain($"Email: {person.Email}");
                modalText.ShouldContain($"First Name: {person.FirstName}");
                modalText.ShouldContain($"Last Name: {person.LastName}");

                closeButton.Click();
            }
        }
    }
}
