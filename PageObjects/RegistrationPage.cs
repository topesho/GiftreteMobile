using GiftreteMobileApp.Hooks;
using GiftreteMobileApp.Utilities;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftreteMobileApp.PageObjects
{
    class RegistrationPage
    {
        Waits _wait;
        FileLocations _fileLocations;
        ElementActions _elementActions;

        public RegistrationPage()
        {
            _wait = new Waits();
            _fileLocations = new FileLocations();
            _elementActions = new ElementActions();
            PageFactory.InitElements(BeforeHooks.driver, this);

        }

        readonly string register = "signup";
        readonly string firstname = "first";
        readonly string lastname = "last";
        readonly string email = "email";
        readonly string mobileNo = "mobile";
        readonly string password = "password";
        readonly string confirmpassword = "repassword";
        readonly string registerbtn = "button";


        public void ClickRegister()
        {
            _elementActions.Click(register);
        }

        public void EnterFirstname(string firstnameText)
        {
            _elementActions.SendKeys(firstname, firstnameText);
        }

        public void EnterLastname(string lastnameText)
        {
            _elementActions.SendKeys(lastname, lastnameText);
        }

        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            _elementActions.SendKeys(email, "test" + randomInt + "@giftrete.com" + "\n");
        }

        public void EnterMobileNo(string mobileno)
        {
            _elementActions.SendKeys(mobileNo, mobileno);
        }

        public void EnterPassword()
        {
            _elementActions.SendKeys(password, "TestPass!23" + "\n");
        }

        public void EnterConfirmPassword(string confirmpasswordText)
        {
            _elementActions.SendKeys(confirmpassword, "TestPass!23" + "\n");
        }

        public void ClickRegisterBtn()
        {
            _elementActions.Click(registerbtn);
        }


    }
}
