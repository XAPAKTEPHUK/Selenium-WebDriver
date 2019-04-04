using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;
using System.Threading;

namespace PetCareTest
{
    [TestFixture]
    public class PetCareTest
    {
        [Test]
        public void PetCare()
        {
            using (var driver = new ChromeDriver())
            {
                /* 1. Open the Care Request page http://nitro.duckdns.org/Pets/careRequest.html */

                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets/careRequest.html");
            
                /* 2. Populate First Name, Last Name, Phone Number, Email */

                var firstName = driver.FindElement(By.Id("firstName"));
                firstName.SendKeys("Ivan");
                firstName.SendKeys(Keys.Tab);

                var lastName = driver.FindElement(By.Name("lastName"));
                lastName.SendKeys("Boychuk");
                lastName.SendKeys(Keys.Tab);

                var phoneNumber = driver.FindElement(By.ClassName("phoneNumber"));
                phoneNumber.SendKeys("7738075366");
                phoneNumber.SendKeys(Keys.Tab);

                var emailAdress = driver.FindElement(By.XPath("//*[@id='emailContainer']/input"));
                emailAdress.SendKeys("boychuk_ivan@rocketmail.com");
                emailAdress.SendKeys(Keys.Tab);

                /* 3. Check Cat checkbox and select 2 from the correspong dropdown */

                var catButton = driver.FindElement(By.Id("cat"));
                catButton.Click();

                var catQuantity = driver.FindElement(By.Id("catQuantity"));
                catQuantity.SendKeys(Keys.NumberPad2);

                /* 4. Check other checkbox and select 3+ from the corresponding dropdown */

                var otherButton = driver.FindElement(By.Id("other"));
                otherButton.Click();

                var otherQuantity = driver.FindElement(By.Id("otherQuantity"));
                otherQuantity.SendKeys(Keys.NumberPad3);

                /* 5. Select Visit several times per day radio button 
                 * and select 2 from the corresponding dropdown */

                var visitSeveralTimesPerDay = driver.FindElement(By.Id("visitSeveralTimesPerDay"));
                visitSeveralTimesPerDay.Click();

                var visitsPerDay = driver.FindElement(By.Id("visitsPerDay"));
                visitsPerDay.SendKeys(Keys.NumberPad2);

                /* 6. Add your comment into the Comment text area */

                var commentArea = driver.FindElement(By.Id("comments"));
                commentArea.SendKeys("Please take care of my pets!");

                /* 7.  Click on Request button */

                var requestButton = driver.FindElement(By.Id("requestButton"));
                requestButton.Click();
                
                /* 8. Verify that the information you've entered on the form 
                 * matches the information on the requested Summary pop-up*/

                var content = driver.FindElement(By.ClassName("modal-content"));
                string expectedText = content.ToString();
                /*string text = "First Name: Ivan " +
                    "Last Name: Boychuk " +
                    "Phone #: 7738075366 " +
                    "Email: boychuk_ivan @rocketmail.com " +
                    "2 cat(s) " +
                    "3 + other animal(s) " +
                    "2 visits per day are required. " +
                    "Comments: " +
                    "Please take care of my pets! ";*/
                expectedText.Contains("First Name: Ivan " +
                    "Last Name: Boychuk " +
                    "Phone #: 7738075366 " +
                    "Email: boychuk_ivan @rocketmail.com " +
                    "2 cat(s) " +
                    "3 + other animal(s) " +
                    "2 visits per day are required. " +
                    "Comments: " +
                    "Please take care of my pets! ");

                /* 9. Click on Close button and verify it closes the pop-up*/
                Thread.Sleep(500);
                var closeButton = driver.FindElement(By.XPath("//*[@class='btn btn-default']"));
                //closeButton = driver.FindElement(By.XPath("//*[@id='myModal']/div/div/div[3]/button"));//*[@id="myModal"]/div/div/div[3]/button
                closeButton.Click();

            }


        }
    }
}
