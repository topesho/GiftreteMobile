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
    class Waits
    {
        public IWebElement WaitForElement(string elementId)
        {
            IWebElement elementFound = null;

            for (var i = 0; i < 5; i++)
            {

                try
                {
                    WebDriverWait fluentWait = new WebDriverWait(BeforeHooks.driver, TimeSpan.FromSeconds(5));

                    fluentWait.Timeout = TimeSpan.FromSeconds(10);
                    fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
                    fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                    elementFound = fluentWait.Until(x => BeforeHooks.driver.FindElement(By.Id(elementId)));
                    if (elementFound.Enabled)
                        break;
                }
                catch
                {

                }


            }

            return elementFound;

        }


        public IWebElement WaitForElement(IWebElement element)
        {
            for (var i = 0; i < 3; i++)
            {

                try
                {
                    DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(BeforeHooks.driver);

                    fluentWait.Timeout = TimeSpan.FromSeconds(5);
                    fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
                    fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                    if (fluentWait.Until(x => element.Enabled))
                        return element;
                }
                catch
                {

                }

            }

            return null;

        }


    }
}
    

