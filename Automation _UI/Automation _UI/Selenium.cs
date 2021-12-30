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
            IWebElement slider = chrome.FindElement(By.XPath("//div[2]/div/div/div/div/label"));
            slider.Click();
            string actual = chrome.FindElement(By.CssSelector("svg[data-icon='moon']")).GetDomAttribute("data-icon");
            Assert.Equal("moon", actual);
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
        public void Test_EdhRec_Create_Rec()
        {
            chrome = StartDriverWithUrl("https://edhrec.com");
            IWebElement rec = chrome.FindElement(By.XPath("//a[contains(@href, '/recs')]"));
            rec.Click();
            IWebElement commander = chrome.FindElement(By.XPath("//div[2]/div/input"));
            commander.Click();
            commander.SendKeys("Veyran, Voice of Duality");
            commander.SendKeys(Keys.ArrowDown);
            commander.SendKeys(Keys.Enter);
            IWebElement decklist = chrome.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div[2]/div[1]/div/div/div/form/div[2]/textarea"));
            decklist.Click();
            decklist.SendKeys("1 Archmage Emeritus \n1 Birgi, God of Storytelling \n1 Dualcaster Mage \n1 Electrostatic Field \n1 Firebrand Archer \n1 Goblin Electromancer" +
                " \n1 Guttersnipe \n1 Harmonic Prodigy \n1 Jori En, Ruin Diver \n1 Kessig Flamebreather \n1 Krark, the Thumbless \n1 Murmuring Mystic \n1 Niv-Mizzet, Parun \n1 " +
                "Smoldering Egg \n1 Storm-Kiln Artist \n1 Talrand, Sky Summoner \n1 Young Pyromancer \n1 Brainstorm \n1 Chaos Warp \n1 Consider \n1 Counterspell \n1 Cyclonic Rift " +
                "\n1 Dig Through Time \n1 Expansion // Explosion \n1 Expedite \n1 Frantic Search \n1 Galvanic Iteration \n1 Narset's Reversal \n1 Negate \n1 Opt \n1 Pongify \n1 Prismari Command" +
                " \n1 Rapid Hybridization \n1 Reinterpret \n1 Reverberate \n1 Seething Song \n1 Valakut Awakening \n1 Blasphemous Act \n1 Crash Through \n1 Expressive Iteration \n1 Faithless Looting " +
                "\n1 Gitaxian Probe \n1 Grapeshot \n1 Jeska's Will \n1 Mana Geyser \n1 Mind's Desire \n1 Mizzix's Mastery \n1 Past in Flames \n1 Ponder \n1 Preordain \n1 Serum Visions \n1 Treasure Cruise" +
                " \n1 Windfall \n1 Aetherflux Reservoir \n1 Arcane Signet \n1 Izzet Signet \n1 Mind Stone \n1 Primal Amulet \n1 Pyromancer's Goggles \n1 Sol Ring \n1 Talisman of Creativity \n1 Thought Vessel" +
                " \n1 Metallurgic Summonings \n1 Sorcerer Class \n1 Swarm Intelligence \n1 Thousand-Year Storm \n1 Ral, Storm Conduit \n1 Command Tower \n1 Exotic Orchard \n1 Frostboil Snarl \n1 Izzet Boilerworks " +
                "\n1 Mystic Sanctuary \n1 Reliquary Tower \n1 Shivan Reef \n1 Steam Vents \n1 Stormcarved Coast \n1 Sulfur Falls \n1 Temple of Epiphany \n1 Training Center \n11 Island \n9 Mountain");
            IWebElement submit = chrome.FindElement(By.XPath("//button[@type='submit']"));
            Thread.Sleep(3000);
            submit.Click();
            Thread.Sleep(3000);
            Assert.Equal("Recs | EDHREC", chrome.Title);
        }
    }
}
