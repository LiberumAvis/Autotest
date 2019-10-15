using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebApplication3
{
    public class NUnitCore
    {//ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\Julia\Desktop", "chromedriver.exe");
      
        //[Test]
        //public void Search_test()
        //{
           

        //    //navigate to Url
        //    //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
           

        //    ////click on Search
        //    ////driver.FindElement(By.CssSelector("body > div > header > div > div > nav > ul > li:nth - child(1) > a"));
        //    ////Enter Testeng
            
        //    ////Click on Buton Serach
        //    //driver.FindElement(By.Id("searchsubmit")).Click();
        //    ////driver.Quit();
        //}
        [SetUp]
        public void Initalize()
        { 
          CollectionDriver.driver = new ChromeDriver(@"C:\Users\Julia\Desktop");
            CollectionDriver.driver.Navigate().GoToUrl("https://fxtrend.info/");
        }
        [Test]
        public void Excecute()
        {
            Class2.EnterText( "s", "hdgshfg", PropetryType.Id);
            Class2.Click( "searchsubmit", PropetryType.Id);
            //IWebElement element = driver.FindElement(By.Id("s"));
            //    element.SendKeys("MaxiMarkets");
          

        }
        [TearDown]
        public void CleanUp()
        {
          //  driver.Quit();
        }
    }
}