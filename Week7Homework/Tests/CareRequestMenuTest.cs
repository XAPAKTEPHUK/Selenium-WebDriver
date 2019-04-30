using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PetCareTest.Pages;

namespace PetCareTest.Test
{
    [TestFixture]
    public class CareRequestMenuTest
    {
        public void MenuTest()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets/careRequest.html");

                var navigationMenuPage = new NavigationMenuPage(driver);
                navigationMenuPage.OpenPicturePage();
                navigationMenuPage.OpenCareRequestPage();
            }
        }
    }
}
