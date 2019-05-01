using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PetCareTests.Pages;
using Shouldly;

namespace PetCareTests.Tests
{
    [TestFixture]
    public class ContactPageTest
    {
        [Test]
        public void ContactMePageTest()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");
                var contactMenuPage = new ContactMePage(driver);

                contactMenuPage.OpenContactPage();

                contactMenuPage.GeContactPagetHeaderText().ShouldBe("Contact Me");

                contactMenuPage.GetPageText().ShouldContain("If you want");
                contactMenuPage.GetPagePhone().ShouldBe("773-800-9646");
                contactMenuPage.GetPageEmail().ShouldBe("vova64@gmail.com");
                contactMenuPage.OpenCareRequestPage();
                contactMenuPage.GetCareRequestTitle().ShouldBe("Care Request");
            }

        }

    }
}