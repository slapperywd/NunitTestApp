using OpenQA.Selenium;

namespace NunitTestApp.Utils
{
    public static class JsUtils
    {
        private static IJavaScriptExecutor js;

        static JsUtils()
        {
            js = Browser.Driver as IJavaScriptExecutor;
        }

        public static void HiglightElementJS(this IWebElement element)
        {
            js.ExecuteScript("arguments[0].style.background = '" + "yellow" + "'", element);
        }

        public static void ClickElementJS(this IWebElement element)
        {
            js.ExecuteScript("arguments[0].click()", element);
        }

        public static void ScrollIntoViewJS(this IWebElement element)
        {
            js.ExecuteScript("arguments[0].scrollIntoView()", element);
        }
    }
}
