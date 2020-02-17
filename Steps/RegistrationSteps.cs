using GiftreteMobileApp.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace GiftreteMobileApp.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage RegistrationPage;

        public RegistrationSteps()
        {
            RegistrationPage = new RegistrationPage();
        }
        [When(@"a user click on register")]
        public void WhenAUserClickOnRegister()
        {
           RegistrationPage.ClickRegister();
        }
        
        [When(@"a user enter firstname ""(.*)""")]
        public void WhenAUserEnterFirstname(string firstname)
        {
            RegistrationPage.EnterFirstname(firstname);
        }
        
        [When(@"a user enter lastname ""(.*)""")]
        public void WhenAUserEnterLastname(string lastname)
        {
            RegistrationPage.EnterLastname(lastname);
        }
        
        [When(@"a user enter email")]
        public void WhenAUserEnterEmail()
        {
           RegistrationPage.EnterEmail();
        }

        [When(@"a user enter mobile ""(.*)""")]
        public void WhenAUserEnterMobile(string mobileno)
        {
            RegistrationPage.EnterMobileNo(mobileno);
        }
       
        [When(@"a user enter password")]
        public void WhenAUserEnterPassword()
        {
            RegistrationPage.EnterPassword();
        }

        [When(@"a user confirm password ""(.*)""")]
        public void WhenAUserConfirmPassword(string confirmpassword)
        {
            RegistrationPage.EnterConfirmPassword(confirmpassword);
        }
        
        [When(@"a user click register")]
        public void WhenAUserClickRegister()
        {
            RegistrationPage.ClickRegisterBtn();
        }
        
        [Then(@"a user is registered")]
        public void ThenAUserIsRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
