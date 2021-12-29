using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Automation__UI
{
    public class Selenium : BaseTest
    {
        IWebDriver chrome;
        public void Dispose()
        {
            chrome.Quit();
        }
        [Fact]
        public void Test_EdhRec_Search_Veyran()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement search = chrome.FindElement(By.CssSelector("input[placeholder='Search']"));
            search.SendKeys("Veyran, Voice of Duality");
            search.SendKeys(Keys.ArrowDown);
            search.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/commanders/veyran-voice-of-duality", actual);
        }
        [Fact]
        public void Test_EdhRec_TopComanders_Urico()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement commanders = chrome.FindElement(By.Id("navbar-commanders"));
            commanders.Click();
            IWebElement top_commanders = chrome.FindElement(By.CssSelector(".dropdown-item:nth-child(1) > span"));
            top_commanders.Click();
            IWebElement Urico = chrome.FindElement(By.XPath("//div[4]/div/div/a/div/img"));
            Urico.Click();
            IWebElement AvarageDecks = chrome.FindElement(By.XPath("//a[contains(text(),'Average Deck')]"));
            AvarageDecks.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/average-decks/yuriko-the-tigers-shadow", actual);
        }
        [Fact]
        public void Test_EdhRec_Community_Cast()
        {
            chrome = StartDriverWithUrl("https://www.edhrec.com");
            IWebElement element = chrome.FindElement(By.LinkText("Community"));
            element.Click();
            string elem = chrome.FindElement(By.CssSelector("a[href='https://www.youtube.com/channel/UCApiDwDpn_JpzRGLZKrdr1g']")).GetAttribute("href");
            Assert.Equal("https://www.youtube.com/channel/UCApiDwDpn_JpzRGLZKrdr1g", elem);
        }
        [Fact]
        public void Test_EdhRec_FromColorless_ToArcaneSignet()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement by_color = chrome.FindElement(By.Id("navbar-cards-by-color"));
            by_color.Click();
            IWebElement colorless_cards = chrome.FindElement(By.XPath("//a[6]/span"));
            colorless_cards.Click();
            IWebElement arcane_signet = chrome.FindElement(By.CssSelector("a[href='/cards/arcane-signet']"));
            arcane_signet.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/cards/arcane-signet", actual);
        }
        [Fact]
        public void Test_EdhRec_FromMultiColor_ToAssassinsTrophy()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement by_color = chrome.FindElement(By.Id("navbar-cards-by-color"));
            by_color.Click();
            IWebElement multicolor_cards = chrome.FindElement(By.XPath("//a[7]/span/span[2]"));
            multicolor_cards.Click();
            Thread.Sleep(1000);
            IWebElement assassinsTrophy = chrome.FindElement(By.CssSelector("a[href='/cards/assassins-trophy']"));
            assassinsTrophy.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/cards/assassins-trophy", actual);
        }
        [Fact]
        public void Test_EdhRec_Dragons_Type()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement themes = chrome.FindElement(By.Id("navbar-themes"));
            themes.Click();
            IWebElement dragons = chrome.FindElement(By.CssSelector("a[href='/tribes/dragons']"));
            dragons.Click();
            IWebElement bigmana = chrome.FindElement(By.CssSelector("a[href='/themes/big-mana/dragons']"));
            bigmana.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/themes/big-mana/dragons", actual);
        }
        [Fact]
        public void Test_EdhRec_Search_Combo_YoreTiller()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement combos = chrome.FindElement(By.CssSelector("a[href='/combos']"));
            combos.Click();
            IWebElement yoreTiller = chrome.FindElement(By.XPath("//span[contains(.,'Yore-Tiller')]"));
            yoreTiller.Click();
            IWebElement saltarBreyaCombo = chrome.FindElement(By.CssSelector("a[href='/combos/wubr/634']"));
            saltarBreyaCombo.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/combos/wubr/634", actual);
        }
        [Fact]
        public void Test_EdhRec_Change_toWhite_Mode()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement cog = chrome.FindElement(By.Id("navbar-cards"));
            cog.Click();
            IWebElement slider = chrome.FindElement(By.XPath("//div[2]/div/div/div/div/label"));
            slider.Click();
            string actual = chrome.FindElement(By.ClassName("modal-open light-mode")).GetCssValue("class");
            Assert.Equal("modal-open light-mode", actual);
        }
        [Fact]
        public void Test_EdhRec_Change_toDark_Mode()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement cog = chrome.FindElement(By.Id("navbar-cards"));
            cog.Click();
            IWebElement slider = chrome.FindElement(By.XPath("//div[2]/div/div/div/div/label"));
            slider.Click();
            string actual = chrome.FindElement(By.ClassName("modal-open dark-mode")).GetCssValue("class");
            Assert.Equal("modal-open dark-mode", actual);
        }
        [Fact]
        public void Test_EdhRec_BlackCards()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
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
        public void Test_EdhRec_Sets_MHC()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement commanders = chrome.FindElement(By.Id("navbar-sets"));
            commanders.Click();
            IWebElement midnight_Hunt_Commanders = chrome.FindElement(By.XPath("//a[4]/span"));
            midnight_Hunt_Commanders.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/sets/mic", actual);
        }
    }
}
