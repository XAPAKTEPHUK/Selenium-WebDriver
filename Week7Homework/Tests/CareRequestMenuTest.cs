using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PetCareTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests.Tests
{
    [TestFixture]
    public class CareRequestMenuTest
    {
        [Test]
        public void MenuTest()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");
                var naviMenuPage = new NavigationMenuPage(driver);
                naviMenuPage.OpenPicturesPage();
                naviMenuPage.OpenCareRequestPage();
            }
        }
    }
}

