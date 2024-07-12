using FluentAssertions;
using NewJobProject.Source.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NewJobProject.Test
{


    public class HomeTest
    {

        private IWebDriver _driver;
       

        [SetUp]
        public void InitiSetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("headless");
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https:www.amazon.co.uk");
        }


        [Test]
        public void Serchpage()
        {
            
            Homepage _homepage = new Homepage(_driver);
            //hp.EnterSerachBox("Greeting Cards");
            _homepage.ClickGroceryButton();
            Assert.True(_driver.Title.Contains("Groceries"));


        }

        [Test]
        public void ClickAllMenu()
        {
            Homepage _homepage = new Homepage(_driver);
            _homepage.ClikcAllMenuButton();

        }

        [Test]
        public void MenuListBoxDisplayed()
        {
            Homepage _homepage = new Homepage(_driver);
            _homepage.ClikcAllMenuButton();
            Thread.Sleep(1000);
            _homepage.MenuListDisplayed.Should().BeTrue();
        }



        //[Test]
        //public void SignInTitlePage()
        //{
        //    Homepage _homepage = new Homepage(_driver);
        //    _homepage.ClikcSignInButton();
        //    Thread.Sleep(1000);
        //    _homepage.EmailTextBoxDisplayed.Should().BeTrue();
        //}

        [TearDown]
        public void TearDown()
        {

            _driver.Dispose();
        }

    }
}
