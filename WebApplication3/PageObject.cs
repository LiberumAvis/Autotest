using Mono.CSharp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatiN.Core;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using How = SeleniumExtras.PageObjects.How;

namespace WebApplication3.PageObjects
{
     class PageObject

    {
        public PageObject()
        {
           // PageFactory.
        }
        IWebDriver driver;

        //[FindBy(How= How.Id, Using = "s")]
        @FindBy(css = "button")
        public IWebElement TitleId { get; set; }

        [FindBy(How = How.Name, Using = "s")]

        public IWebElement TitleId { get; set; }

    }
}