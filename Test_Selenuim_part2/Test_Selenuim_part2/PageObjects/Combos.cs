using System;
using OpenQA.Selenium;

namespace Test_Selenuim_part2
{
    public class Combos
    {
        private IWebDriver _driver;
        private By _navcards = By.Id("navbar-cards");
        private By _combosButton = By.LinkText("Combos");
        public Combos(IWebDriver driver)
        {
            _driver = driver;
        }
        public Combos clickCards()
        {
            _driver.FindElement(_navcards).Click();
            return this;
        }
        public Combos clickCombos()
        {
            _driver.FindElement(_combosButton).Click();
            return new Combos(_driver);
        }
    }
}
