using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PetCareTests.Pages;
using PetCareTests.TestData;
using Shouldly;


namespace PetCareTests.Tests
{
    [TestFixture]
    public class CareRequestTest
    {
        [Test]
        public void CareRequestPageTest()
        {
            var person = new Person();




            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                var navigationMenuPage = new NavigationMenuPage(driver);
                navigationMenuPage.OpenCareRequestPage();

                //Fill out form
                var careRequestPage = new CareRequestPage(driver);
                careRequestPage.FillOutContactInformation(person);
                //Choose a pet by checking checkbox , Choose amount of pets in the dropdown
                careRequestPage.RequestCatCare("3+");
                //Choose number of visit per day //Choose how many times per day
                careRequestPage.SetVisitsPerDay(4);

                //Type additionl comments
                careRequestPage.FillOutComments("I would like to hire a person for 1-2 years.");
                //var yourComments = driver.FindElement(By.Id("comments"));
                //yourComments.SendKeys("I would like to hire a person for 1-2 years.");

                //Submit your request
                //var requestButton = driver.FindElement(By.Id("requestButton"));
                //requestButton.Click();
                careRequestPage.ClickRequestButton();

                //var requestSummaryPage = new RequestSummaryPage();
                // var username = requestSummaryPage.GetUserName();
                // username.ShouldBe("Vova S");


                Thread.Sleep(1000);
                var requestSummaryPage = new RequestSummaryPage(driver);
                var modalText = requestSummaryPage.GetModalText();


                Console.WriteLine(modalText);
                modalText.ShouldContain($"Phone #: {person.PhoneNumber}");
                modalText.ShouldContain($"Email: {person.Email}");
                modalText.ShouldContain($"First Name: {person.FirstName}");
                modalText.ShouldContain($"Last Name: {person.LastName}");

                requestSummaryPage.CloseModal();
            }
        }
    }
}