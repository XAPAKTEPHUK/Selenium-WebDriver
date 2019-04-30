﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PetCareTest.Pages
{
    public class NavigationMenuPage
    {
        private IWebDriver driver;

        public NavigationMenuPage(IWebDriver outsideDriver)
        {
            driver = outsideDriver;
        }
        private IWebElement CareRequestMenuItem => driver.FindElement(By.LinkText("CareRequest"));

        private IWebElement PictureMenuItem => driver.FindElement(By.LinkText("Pictures"));

        public void OpenCareRequestPage()
        {
            CareRequestMenuItem.Click();
        }
        public void OpenPicturePage()
        {
            PictureMenuItem.Click();
        }

    }
}
