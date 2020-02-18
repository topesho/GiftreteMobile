using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GiftreteMobileApp.Hooks
{
    [Binding]
    public class BeforeHooks
    {
        
       public static  AppiumDriver<IWebElement> driver;


        [BeforeScenario]
        public static void BeforeScenario()
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

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.quit();
        }
    }
}
