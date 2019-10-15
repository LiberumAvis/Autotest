using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication3
{
   public enum PropetryType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    public class CollectionDriver
    {

        public static IWebDriver driver { get; set; }

    }
}