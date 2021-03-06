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
            IWebElement cog = chrome.FindElement(By.XPath("//div[4]/button"));
            cog.Click();
            IWebElement elem_check = chrome.FindElement(By.XPath("/html/body/div[3]/div/div/div[2]/div/div[1]/div/div/label"));
            elem_check.Click();
            string sun = chrome.FindElement(By.CssSelector("svg[data-icon='sun']")).GetDomAttribute("data-icon");
            Assert.Equal("sun", sun);
            IWebElement slider_return = chrome.FindElement(By.XPath("/html/body/div[3]/div/div/div[2]/div/div[1]/div/div/label"));
            slider_return.Click();
            IWebElement exit = chrome.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/button/span[1]"));
            exit.Click();
        }
        [Fact]
        public void Test_EdhRec_FromMask_ToThrun()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement cards = chrome.FindElement(By.Id("navbar-cards"));
            cards.Click();
            IWebElement type = chrome.FindElement(By.Id("navbar-cards-by-type"));
            type.Click();
            IWebElement auras = chrome.FindElement(By.XPath("//span[contains(.,'Auras')]"));
            auras.Click();
            IWebElement ancestralMask = chrome.FindElement(By.CssSelector("a[href='/cards/ancestral-mask']"));
            ancestralMask.Click();
            IWebElement thrun = chrome.FindElement(By.CssSelector("a[href='/commanders/thrun-the-last-troll']"));
            thrun.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/commanders/thrun-the-last-troll", actual);
        }
        [Fact]
        public void Test_EdhRec_FromFiveColors_ToTheUrDragon()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement commanders = chrome.FindElement(By.Id("navbar-commanders"));
            commanders.Click();
            IWebElement fourPlusColor = chrome.FindElement(By.Id("navbar-commanders-4-5-color"));
            fourPlusColor.Click();
            IWebElement fiveColor = chrome.FindElement(By.XPath("//span[6]"));
            fiveColor.Click();
            IWebElement bigMana = chrome.FindElement(By.XPath("//div[4]/a/div/span"));
            bigMana.Click();
            IWebElement dragons = chrome.FindElement(By.XPath("//span[contains(.,'Dragons')]"));
            dragons.Click();
            IWebElement theUr_Dragon = chrome.FindElement(By.XPath("//img[@alt='The Ur-Dragon']"));
            theUr_Dragon.Click();
            string actual = chrome.Url;
            Assert.Equal("https://edhrec.com/commanders/the-ur-dragon/dragon", actual);
        }
    }
}
