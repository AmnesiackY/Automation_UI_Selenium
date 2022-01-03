using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Automation__UI
{
    public class BaseTest : IDisposable
    {
        private IWebDriver _driver;
        public void Dispose()
        {
            _driver.Quit();
        }
        public IWebDriver StartDriverWithUrl(string url)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            _driver.Navigate().GoToUrl(url);
            return _driver;
        }
    }
}
