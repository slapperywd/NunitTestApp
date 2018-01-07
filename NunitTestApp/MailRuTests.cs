using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NunitTestApp.Pages.MailRu;
using NunitTestApp.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestApp
{
    [TestFixture]
    public class MailRuTests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            //driver = new InternetExplorerDriver();
            Browser.Init(DriverType.Chrome);
            driver = Browser.Driver;
            driver.Manage().Window.Maximize();
            //Base URL
            driver.Url = "https://mail.ru/";
        }

        [Test]
        public void MailRuTest()
        {
            var resultShopPage = new MailHomePage()
                .SignInMailAccount("maglish", "1234Slapper");
               
           
        }

        [TearDown]
        public void TearDown()
        {
            //if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
            //{
            //    var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            //    screenshot.SaveAsFile($@"D:\Screenshots\{TestContext.CurrentContext.Test.Name}.jpg", ScreenshotImageFormat.Jpeg);
            //}
            //driver.Quit();
        }
    }
}
