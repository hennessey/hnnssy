using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace hnnssy.Tests.PageObjects
{
    public class Homepage
    {
        [FindsBy(How = How.Id, Using = "myname")]
        public IWebElement Title;

        private static IWebDriver _driver;

        public static Homepage NavigateTo(IWebDriver driver)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl("http://localhost:26145/");

            var homePage = new Homepage();

            PageFactory.InitElements(driver, homePage);

            return homePage;
        }




    }
}
