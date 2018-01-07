using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NunitTestApp.Pages
{
    public class EntryNewsPage:BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "h3.entry-head a")]
        private IWebElement entryHead;

        public void Open()
        {
            entryHead.Click();
        }

    }
}
