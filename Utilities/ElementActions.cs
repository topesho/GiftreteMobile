using GiftreteMobileApp.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftreteMobileApp.Utilities
{
    class ElementActions
    {
        private Waits _wait;
        private object _elementActions;

        public ElementActions()
        {
            _wait = new Waits();
        }

        public void Click(string Id)
        {
            IWebElement element = _wait.WaitForElement(Id);

            element.Click();

            //_wait.WaitForElement(cssSelector).Click();

        }


        
        public IWebElement GetElement(string Id)
        {
            return _wait.WaitForElement(Id);

        }

        public string GetTextFromElement(string Id)
        {
            return _wait.WaitForElement(Id).Text;

        }

        public void Clear(string Id)
        {
            IWebElement element = _wait.WaitForElement(Id);

            element.Clear();

            // _wait.WaitForElement(cssSelector).Click();

        }

        public void ClickByPressingEnterKey(string Id)
        {
            IWebElement element = _wait.WaitForElement(Id);
            element.SendKeys(Keys.Enter);


        }

        public void SendKeys(string Id, string textToEnter)
        {
            _wait.WaitForElement(Id).SendKeys(textToEnter);
        }

        public void SelectFromDropDownByIndex(string Id, int index)
        {
            SelectElement select = new SelectElement(_wait.WaitForElement(Id));
            select.SelectByIndex(index);
        }

        public void SelectFromDropDownByText(string Id, string text)
        {
            SelectElement select = new SelectElement(_wait.WaitForElement(Id));
            select.SelectByText(text);
        }

        public void SelectFromDropDownByValue(string Id, string value)
        {
            SelectElement select = new SelectElement(_wait.WaitForElement(Id));
            select.SelectByValue(value);
        }

        public bool IsElementDisplayed(string Id)
        {
            try
            {
                return _wait.WaitForElement(Id).Displayed;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IList<IWebElement> GetListOfElements(string Id)
        {
            return BeforeHooks.driver.FindElements(By.Id(Id));
        }


        public bool IsElementPresentInAList(string Id, string text)
        {
            foreach (IWebElement element in GetListOfElements(Id))
            {
                if (element.Text == text)
                    return true;
            }

            return false;
        }
    }
}


    

