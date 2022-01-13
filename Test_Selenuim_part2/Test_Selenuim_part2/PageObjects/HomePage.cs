using System;
using OpenQA.Selenium;

namespace Test_Selenuim_part2
{
    public class HomePage
    {
        private IWebDriver _driver;
        private By _navcards = By.Id("navbar-cards");
        private By _topCards = By.XPath("//span[contains(.,'Top Cards')]");
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public HomePage clickCards()
        {
            _driver.FindElement(_navcards).Click();
            return this;
        }
        public TopCards clickTopCards()
        {
            _driver.FindElement(_topCards).Click();
            return new TopCards(_driver);
        }
    }
}
