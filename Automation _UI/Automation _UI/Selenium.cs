using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Automation__UI
{
    public class Selenium : IDisposable
    {
        IWebDriver chrome;
        public void Dispose()
        {
            chrome.Quit();
        }
        [Fact]
        public void Test_EdhRec_Search()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement search = chrome.FindElement(By.CssSelector("input[placeholder='Search']"));
            search.SendKeys("Veyran, Voice of Duality");
            search.SendKeys(Keys.ArrowDown);
            search.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/commanders/veyran-voice-of-duality", actual);
        }
        [Fact]
        public void Test_EdhRec_TopComanders()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement commanders = chrome.FindElement(By.Id("navbar-commanders"));
            commanders.Click();
            IWebElement top_commanders = chrome.FindElement(By.CssSelector("a[href='/commanders']"));
            top_commanders.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/commanders", actual);

        }
        [Fact]
        public void Test_EdhRec_GreenCards()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement by_color = chrome.FindElement(By.Id("navbar-cards-by-color"));
            by_color.Click();
            IWebElement green_cards = chrome.FindElement(By.CssSelector("a[href='/top/g']"));
            green_cards.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/top/g", actual);
        }
        [Fact]
        public void Test_EdhRec_ColorlessCards()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement by_color = chrome.FindElement(By.Id("navbar-cards-by-color"));
            by_color.Click();
            IWebElement green_cards = chrome.FindElement(By.CssSelector("a[href='/top/colorless']"));
            green_cards.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/top/colorless", actual);
        }
        [Fact]
        public void Test_EdhRec_MultiColorCards()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement by_color = chrome.FindElement(By.Id("navbar-cards-by-color"));
            by_color.Click();
            IWebElement green_cards = chrome.FindElement(By.CssSelector("a[href='/top/multi']"));
            green_cards.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/top/multi", actual);
        }
        [Fact]
        public void Test_EdhRec_RedCards()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement by_color = chrome.FindElement(By.Id("navbar-cards-by-color"));
            by_color.Click();
            IWebElement green_cards = chrome.FindElement(By.CssSelector("a[href='/top/r']"));
            green_cards.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/top/r", actual);
        }
        [Fact]
        public void Test_EdhRec_WhiteCards()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement by_color = chrome.FindElement(By.Id("navbar-cards-by-color"));
            by_color.Click();
            IWebElement green_cards = chrome.FindElement(By.CssSelector("a[href='/top/w']"));
            green_cards.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/top/w", actual);
        }
        [Fact]
        public void Test_EdhRec_BlueCards()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement by_color = chrome.FindElement(By.Id("navbar-cards-by-color"));
            by_color.Click();
            IWebElement green_cards = chrome.FindElement(By.CssSelector("a[href='/top/u']"));
            green_cards.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/top/u", actual);
        }
        [Fact]
        public void Test_EdhRec_BlackCards()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement by_color = chrome.FindElement(By.Id("navbar-cards-by-color"));
            by_color.Click();
            IWebElement green_cards = chrome.FindElement(By.CssSelector("a[href='/top/b']"));
            green_cards.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/top/b", actual);
        }
        [Fact]
        public void Test_EdhRec_Sets()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://edhrec.com");
            IWebElement commanders = chrome.FindElement(By.Id("navbar-sets"));
            commanders.Click();
            IWebElement midnight_Hunt_Commanders = chrome.FindElement(By.CssSelector("a[href='/sets/mic']"));
            midnight_Hunt_Commanders.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/sets/mic", actual);
        }
    }
}
