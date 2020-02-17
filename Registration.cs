//using System;
//using System.Threading;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Appium;
//using OpenQA.Selenium.Appium.Android;




//namespace GiftreteMobileApp
//{
//    [TestClass]
//    public class Registration
//    {
//        //Creating inatance for AppiumDriver
//        //AndroidDriver<AndroidElement> driver;
//        AppiumDriver<IWebElement> driver;

        


//        [TestMethod]
        
//        public void TestMethod()
//        {
//           AppiumOptions cap = new AppiumOptions();
//            cap.AddAdditionalCapability("platformName", "Android");
//            cap.AddAdditionalCapability("deviceName", "nokia7plus");
//            cap.AddAdditionalCapability("udid", "B2NGAA9832502143");
//            cap.AddAdditionalCapability("platformVersion", "6.0");
//            cap.AddAdditionalCapability("appPackage", "gift.giftrete.com");
//            cap.AddAdditionalCapability("appActivity", "gift.giftrete.com.SplashScreenActivity");

//            //Launch the Android driver

//            //driver = new AndroidDriver<AndroidElement>(new URi("http://127.0.0.1:4723/wd/hub"), cap);
//            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.01:4723/wd/hub"), cap);
//            //Assert.IsNotNull(driver.Context);
            
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


//            AppiumDriver<IWebElement> driver = BeforeHooks.driver;

//            driver.FindElementById("txtnext").Click();
//            driver.FindElementById("txtnext").Click();
//            driver.FindElementById("txtnext").Click();

            
//            driver.FindElementById("signup").Click();
//            driver.FindElementById("first").SendKeys("tester");
//            driver.FindElementById("last").SendKeys("giftrete");
//            Random randomGenerator = new Random();
//            int randomInt = randomGenerator.Next(1000);
//            driver.FindElementById("email").SendKeys("test" + randomInt + "@giftrete.com");
//            driver.FindElementById("mobile").SendKeys("0775555555");
//            driver.FindElementById("password").SendKeys("TestPass!23" + "\n");
//            driver.FindElementById("repassword").SendKeys("TestPass!23" + "\n");
//            driver.FindElementById("button").Click();















//        }
//    }
//}
