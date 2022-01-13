using System;
using OpenQA.Selenium;

namespace Test_Selenuim_part2
{
    public class Salties
    {
        private IWebDriver _driver;
        private By _navcards = By.Id("navbar-cards");
        private By _saltiesButton = By.LinkText("Saltiest Cards");
        public Salties(IWebDriver driver)
        {
            _driver = driver;
        }
        public Salties clickCards()
        {
            _driver.FindElement(_navcards).Click();
            return this;
        }
        public Salties clickSalties()
        {
            _driver.FindElement(_saltiesButton).Click();
            return new Salties(_driver);
        }
    }
}
