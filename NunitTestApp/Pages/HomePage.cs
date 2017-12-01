using NunitTestApp.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestApp.Pages
{
    public class HomePage:BasePage
    {
        [FindsBy(How = How.Id, Using = "search_from_str")]
        private IWebElement searchInput;

        [FindsBy(How = How.CssSelector, Using = "li#search-6-target a")]
        private IWebElement searchShopsLink;

        [FindsBy(How = How.Name, Using = "search")]
        private IWebElement searchBtn;

        public HomePage SetSearchShops()
        {
            searchInput.Click();
            searchShopsLink.Click();
            return this;
        }

        public T Search<T>(string text) where T:new()
        {
            searchInput.SendKeys(text);
            searchBtn.Click();
            return new T();
        }
    }
}
