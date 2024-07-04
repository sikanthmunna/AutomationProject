using FluentAssertions;
using NewJobProject.Source.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NewJobProject.Test
{


    public class LoginTest
    {

        private IWebDriver _driver;


        [SetUp]
        public void InitiSetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https:www.amazon.co.uk");
        }


        [Test]
        public void Serchpage()
        {
            Homepage _homepage = new Homepage(_driver);

        }

        [Test]
        public void ClickAllMenu()
        {
            Homepage _homepage = new Homepage(_driver);

        }

        [Test]
        public void MenuListBoxDisplayed()
        {
            Homepage _homepage = new Homepage(_driver);
            
        }



        [Test]
        public void SignInTitlePage()
        {
            Homepage _homepage = new Homepage(_driver);
            
        }

        [TearDown]
        public void TearDown()
        {

            _driver.Dispose();
        }

    }
}
