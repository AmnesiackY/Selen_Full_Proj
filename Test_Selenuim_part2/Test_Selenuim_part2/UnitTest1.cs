using System;
using Xunit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Test_Selenuim_part2
{
    public class UnitTests
    {
        IWebDriver chrome;
        public IWebDriver StartDriverOnPage (string url)
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            chrome.Navigate().GoToUrl(url);
            return chrome;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void Test_ClickTopCards()
        {
            chrome = StartDriverOnPage("https://edhrec.com/");
            HomePage homePage = new HomePage(chrome);
            homePage.clickCards().clickTopCards();
        }
        [Fact]
        public void Test_TopCardsClickAPastWeek()
        {
            chrome = StartDriverOnPage("https://edhrec.com/top");
            TopCards topCards = new TopCards(chrome);
            topCards.clickPastWeek();
        }
        [Fact]
        public void Test_ClickSalties()
        {
            chrome = StartDriverOnPage("https://edhrec.com/");
            Salties salties = new Salties(chrome);
            salties.clickCards().clickSalties();
        }
        [Fact]
        public void Test_ClickCombos()
        {
            chrome = StartDriverOnPage("https://edhrec.com/");
            Combos combos = new Combos(chrome);
            combos.clickCards().clickCombos();
        }
    }
}
