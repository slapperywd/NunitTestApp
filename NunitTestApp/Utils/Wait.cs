using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NunitTestApp.Utils
{
    public class Wait
    {
        private static WebDriverWait wait;
        private const int defaultTimeout = 15;

        public static IWebElement Until(Func<IWebDriver, IWebElement> condition, int timeout = defaultTimeout)
        {
            wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(timeout));
            return wait.Until(condition);
        }

        public static bool Until(Func<IWebDriver, bool> condition, int timeout = defaultTimeout)
        {
            wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(timeout));
            return wait.Until(condition);
        }
    }
}
