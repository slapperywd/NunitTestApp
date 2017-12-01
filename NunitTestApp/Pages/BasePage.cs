using NunitTestApp.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestApp.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage()
        {
            driver = Browser.Driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            PageFactory.InitElements(driver, this);
        }
    }
}
