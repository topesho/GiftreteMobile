using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;


namespace GiftreteMobileApp
{
    [TestClass]
    public class Community

    {
        AppiumDriver<IWebElement> driver;

        [TestMethod]
        public void TestMethod1()
        {
            AppiumOptions cap = new AppiumOptions();
            cap.AddAdditionalCapability("platformName", "Android");
            cap.AddAdditionalCapability("deviceName", "nokia7plus");
            cap.AddAdditionalCapability("udid", "B2NGAA9832502143");
            cap.AddAdditionalCapability("platformVersion", "6.0");
            cap.AddAdditionalCapability("appPackage", "gift.giftrete.com");
            cap.AddAdditionalCapability("appActivity", "gift.giftrete.com.SplashScreenActivity");


            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.01:4723/wd/hub"), cap);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.FindElementById("txtnext").Click();
            driver.FindElementById("txtnext").Click();
            driver.FindElementById("txtnext").Click();

            driver.FindElementById("email").SendKeys("test@giftrete.com" + "\n");
            driver.FindElementById("passwordli").SendKeys("TestPass!23" + "\n");
            driver.FindElementById("button").Click();

            driver.FindElementById("navigation_cart").Click();
            driver.FindElementById("createcommunity").Click();
            driver.FindElementById("name").SendKeys("Testing");
            driver.FindElementById("description").SendKeys("Testing2");
            driver.FindElementById("status").Click();
            driver.FindElementById("tv_tinted_spinner").Click();
            driver.FindElementById("type").Click();
            driver.FindElementById("tv_tinted_spinner").Click();
            driver.FindElementById("location").SendKeys("London");
            driver.FindElementById("website").SendKeys("www.giftrete.com");
            driver.HideKeyboard();
            driver.FindElementById("regUserPhoto").Click();
            driver.FindElementById("title").Click();
            driver.FindElementById("ContinueButton").Click();
        }
    }
}
