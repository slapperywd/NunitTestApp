using NunitTestApp.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestApp.Pages
{
    public class SearchShopResultPage:BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='h']/div")]
        private IList<IWebElement> goods;

        public SearchShopResultPage():base()
        {
        }

        public IList<IWebElement> Goods
        {
            get
            {
                wait.Until(x => goods.Count > 0);
                return goods;
            }
        }
    }
}
