﻿using DWC_BDD_Tests.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using DWC_BDD_Tests.Shared;
using System.Collections.ObjectModel;

namespace DWC_BDD_Tests.PageObjects
{
    public class MapsPageObject : PageObject
    {
        public MapsPageObject(IWebDriver webDriver) : base(webDriver)
        {
            // using a named page (in Common.cs)
            _pageName = "Maps";
        }

        public IWebElement RegisterButton => _webDriver.FindElement(By.Id("register-link"));
        public IWebElement NavBarHelloLink => _webDriver.FindElement(By.CssSelector("a[href=\"/Identity/Account/Manage\"]"));





        public string NavbarWelcomeText()
        {
            return NavBarHelloLink.Text;
        }

        public void Logout()
        {
            IWebElement navbarLogoutButton = _webDriver.FindElement(By.Id("logout-button"));
            navbarLogoutButton.Click();
        }
    }
}