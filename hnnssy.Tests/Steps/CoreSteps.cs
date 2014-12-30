using System.Globalization;
using hnnssy.Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace hnnssy.Tests
{
    [Binding]
    public class CoreSteps
    {
        private Homepage _homepage;
        private IWebDriver _driver;

        [BeforeScenario()]
        public void Setup()
        {
            _driver = new FirefoxDriver();
        }

        [AfterScenario()]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            _homepage = Homepage.NavigateTo(_driver);
        }

        [Then(@"the title tag should indicate that it's my site")]
        public void ThenTheTitleTagShouldIndicateThatItSMySite()
        {
            Assert.AreEqual(_driver.Title.ToString(CultureInfo.InvariantCulture), "John Hennessey");
        }
    }
}
