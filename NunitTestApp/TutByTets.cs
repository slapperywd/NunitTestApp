using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NunitTestApp.Utils;
using NUnit.Framework.Internal;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using NunitTestApp.Pages;
using System.Threading;

namespace NunitTestApp
{
    [TestFixture]
    public class TutByTets
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
            driver.Url = "https://www.tut.by/";
        }

        [Test]
        public void SelectionTextTest()
        {
            driver.FindElement(By.ClassName("eeeeassa"));
            driver.FindElement(By.ClassName("entry-anounce")).HiglightElementJS();
            driver.FindElement(By.XPath("//div[@class='b-newsfeed']/div")).HiglightElementJS();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".entry-head a")).ClickElementJS();
            driver.FindElement(By.CssSelector(".b-article h2")).ScrollIntoViewJS();
            driver.FindElement(By.CssSelector(".b-article p:nth-child(4)")).HiglightElementJS();
            //driver.FindElement(By.XPath("//ul[@class='hottags__list']/li//a[text()='Беларусь-Украина']")).Higlight(driver);

            //driver.FindElement(By.XPath("//ul[@class='hottags__list']/li//a[contains(., 'Беларусь')]")).Higlight(driver);

            //driver.FindElement(By.XPath("//ul[@class='hottags__list']/li//a[contains(text(), 'Беларусь')]")).Higlight(driver);
        }

        [Test]
        [Ignore("")]
        public void FailedTest()
        {
            driver.Url = "https://www.tut.by/";
            driver.FindElement(By.ClassName("Test"));
        }

        [Test]
        [Ignore("")]
        public void FailedTest1()
        {
            driver.Url = "https://www.onliner.by/";
            driver.FindElement(By.ClassName("Test"));
        }

        [Test]
        public void SearchShop()
        {
            var resultShopPage = new HomePage()
                .SetSearchShops()
                .Search<SearchShopResultPage>("aaaa");

            Console.Out.WriteLine(resultShopPage.Goods.Count);
            Assert.IsTrue(resultShopPage.Goods.Count > 0);
        }

        [Test]
        public void EntryNews()
        {
            new HomePage()
                .OpenEntryNews();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
            {
                string filePath = $@"D:\Screenshots\{TestContext.CurrentContext.Test.Name}.jpg";
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Jpeg);
                TestContext.AddTestAttachment(filePath);
            }
            //driver.Quit();
        }

    }
}
