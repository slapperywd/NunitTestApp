using NunitTestApp.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestApp.Pages.MailRu
{
    public class MailHomePage:BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='login']")]
        private IWebElement mailLoginInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement mailPasswordInput;

        [FindsBy(How = How.XPath, Using = "//input[@class='o-control']")]
        private IWebElement loginButton;

        public MailHomePage SignInMailAccount(string login, string password)
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(mailLoginInput));
            mailLoginInput.SendKeys(login);
            mailPasswordInput.SendKeys(password);
            loginButton.Submit();
            return this;
        }
    }
}
