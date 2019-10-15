using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace WebApplication3.Tests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        public IWebDriver driver;
        [Given(@"Launch Chrome")]
        public void GivenLaunchChrome()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\Julia\Desktop\");
            //Launch browser
            driver = new ChromeDriver(service);

            //navigate to Url
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);

        }

        [Given(@"Navigate to fxtrends")]
        public void GivenNavigateToFxtrends()
        {
            driver.Navigate().GoToUrl("https://fxtrend.info/");

        }

        [When(@"Enter MaxiMarkets")]
        public void WhenEnterMaxiMarkets()
        {
            driver.FindElement(By.Id("s")).SendKeys("MaxiMarkets");
        }

        [When(@"Click on Search Button")]
        public void WhenClickOnSearchButton()
        {
            driver.FindElement(By.Id("searchsubmit")).Click();
        }

        [Then(@"Results should be visible and Browser shold close")]
        public void ThenResultsShouldBeVisibleAndBrowserSholdClose()
        {
            driver.Quit(); ;
        }
    }
}
