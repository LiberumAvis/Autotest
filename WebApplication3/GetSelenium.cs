using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class GetSelenium
    {
        public static string GetText( string element, string valuetype)
        {

            if (valuetype.ToLower() == "id")
                return CollectionDriver.driver.FindElement(By.Id(element)).Text;
            else if (valuetype == "Name")
                return CollectionDriver.driver.FindElement(By.Name(element)).Text;
            else return String.Empty;
        }
    }
}