using System;
using OpenQA.Selenium;

namespace Test_Selenuim_part2
{
    public class TopCards
    {
        private IWebDriver _driver;
        private By _pastweekButton = By.LinkText("Past Week");
        public TopCards(IWebDriver driver)
        {
            _driver = driver;
        }
        public TopCards clickPastWeek()
        {
            _driver.FindElement(_pastweekButton).Click();
            return this;
        }
    }
}
