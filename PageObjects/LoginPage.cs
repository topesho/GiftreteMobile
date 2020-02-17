using GiftreteMobileApp.Hooks;
using GiftreteMobileApp.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftreteMobileApp.PageObjects
{
    public class LoginPage 
    {
        Waits _wait;
        FileLocations _fileLocations;
        ElementActions _elementActions;
        public LoginPage()
        {
            _wait = new Waits();
            _fileLocations = new FileLocations();
            _elementActions = new ElementActions();
            PageFactory.InitElements(BeforeHooks.driver, this);

        }

        readonly string email = "email";
        readonly string password = "passwordli";
        readonly string login = "button";
        //readonly string navigationbar = "navigationBarBackground";

        public void EnterEmail(string emailText)
        {
            _elementActions.SendKeys(email, emailText + "\n");
        }

        public void EnterPassword(string passwordText)
        {
            _elementActions.SendKeys(password, passwordText + "\n");
        }
        
        public void ClickLogin()
        {
            _elementActions.Click(login);
        }

        public bool IsElementDisplayed(string navigationbar)
        {
            try
            {
                return _wait.WaitForElement(navigationbar).Displayed;
            }
            catch (Exception)
            {

                return false;
            }
        }



    }
}
