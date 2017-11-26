using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestApp.Utils
{
    class Browser
    {
        private static IWebDriver _driver;

        public static void Init(DriverType driverType)
        {
            switch (driverType)
            {
                case DriverType.Chrome:
                    _driver = new ChromeDriver();
                    break;
                case DriverType.Firefox:
                    _driver = new FirefoxDriver();
                    break;
                case DriverType.IE:
                    InternetExplorerOptions ieOptions = new InternetExplorerOptions();
                    ieOptions.InitialBrowserUrl = @"https://github.com/EugeneFaceControl?tab=repositories";
                   // ieOptions.IgnoreZoomLevel = true;
                    _driver = new InternetExplorerDriver(ieOptions);
                    break;
                case DriverType.Edge:
                    _driver = new EdgeDriver();
                    break;
                default:
                    throw new Exception("Invalid driver type");
                    break;
            }
        }

        public static IWebDriver Driver => _driver;
    }
}
