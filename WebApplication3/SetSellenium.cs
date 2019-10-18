using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium.Support.UI;
namespace WebApplication3
{
    public class SetSellenium
    {

       public static void EnterText(string element, string value, PropetryType valuetype)
        {

            if(valuetype == PropetryType.Id)
                CollectionDriver.driver.FindElement(By.Id(element)).SendKeys(value);
            if(valuetype == PropetryType.Name)
                CollectionDriver.driver.FindElement(By.Name(element)).SendKeys(value);
        }
        public static void Click( string element, PropetryType  valuetype)
        {

            if (valuetype == PropetryType.Id)
                CollectionDriver.driver.FindElement(By.Id(element)).Click();
            if (valuetype == PropetryType.Name)
                CollectionDriver.driver.FindElement(By.Name(element)).Click();

        }
    }
}