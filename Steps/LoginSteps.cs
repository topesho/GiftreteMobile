using GiftreteMobileApp.Hooks;
using GiftreteMobileApp.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using TechTalk.SpecFlow;

namespace GiftreteMobileApp.Steps
{
    [Binding]
    public class LoginSteps
    {
       LoginPage LoginPage;

        public LoginSteps()
        {
            LoginPage= new LoginPage ();
        }

        [Given(@"a user launch Giftrete App")]
        public void GivenAUserLaunchGiftreteApp()
        {
            AppiumDriver<IWebElement> driver = BeforeHooks.driver;

            driver.FindElementById("txtnext").Click();
            driver.FindElementById("txtnext").Click();
            driver.FindElementById("txtnext").Click();
        }

        [When(@"a user enter email ""(.*)""")]
        public void WhenAUserEnterEmail(string email)
        {
            LoginPage.EnterEmail(email);
        }



        [When(@"a user enter password ""(.*)""")]
        public void WhenAUserEnterPassword(string password)
        {
           LoginPage.EnterPassword(password);
        }


        [When(@"a user click login")]
        public void WhenAUserClickLogin()
        {
            LoginPage.ClickLogin();
        }


        [Then(@"a user is signed in")]
        public void ThenAUserIsSignedIn()
        {
            //Assert.IsTrue(BeforeHooks.driver.FindElementById("navigationBarBackground").Displayed);
            IWebElement toastView = BeforeHooks.driver.FindElement(By.XPath("//android.widget.Toast 201[1]"));
            String text = toastView.GetAttribute("Successfull Login");
            //Assert.IsTrue();
        }
    }
}
