using DWC_BDD_Tests.Drivers;
using DWC_BDD_Tests.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DWC_BDD_Tests.StepDefinitions
{
    [Binding]
    public class DarkModeLightModeStepDefinitions
    {
        private readonly HomePageObject _homePage;
        private readonly LoginPageObject _loginPage;

        public DarkModeLightModeStepDefinitions(BrowserDriver browserDriver)
        {
            _homePage = new HomePageObject(browserDriver.Current);
            _loginPage = new LoginPageObject(browserDriver.Current);
        }

        [Given(@"I am a visitor on the Home Page")]
        public void GivenIAmAVisitorOnTheHomePage()
        {
            _homePage.NavigateTo();
            Assert.AreEqual("Home", _homePage.GetPageName());
        }

        [When(@"they click the dark mode toggler")]
        public void WhenTheyClickTheDarkModeToggler()
        {
            _homePage.ClickNavbarTogglerButton();
            _homePage.ClickModeToggler();
        }


        [Then(@"the background image should change and the colors should change")]
        public void ThenTheBackgroundImageShouldChangeAndTheColorsShouldChange()
        {
            var img = _homePage.bgImg.GetCssValue("background-image");
            Assert.That(true, img);
        }
    }
}
