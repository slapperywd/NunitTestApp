using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestApp.Utils
{
    public static class SeleniumUtils
    {
        public static void Higlight(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].style.background = '" + "yellow" + "'", element);
            
        }
    }
}
