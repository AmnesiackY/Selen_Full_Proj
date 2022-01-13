using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Test_Selenuim_part2
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
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            _driver.Navigate().GoToUrl(url);
            return _driver;
        }
    }
}
