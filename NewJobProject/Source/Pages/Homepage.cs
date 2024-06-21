using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewJobProject.Source.Pages
{
    public class Homepage
    {
        
        private IWebDriver _driver;
        private IWebElement SearchBox => _driver.FindElement(By.Id("twotabsearchtextbox"));
        private IWebElement SearchButton => _driver.FindElement(By.Id("nav-search-submit-button"));
        private IWebElement GroceryButton => _driver.FindElement(By.Id("nav-link-groceries"));



        public Homepage(IWebDriver driver)
        {
            _driver = driver;

        }


        public void EnterSerachBox(string data)
        {
            SearchBox.SendKeys(data);

        }

        public void ClickSearchButton() => SearchButton.Click();

        public void ClickGroceryButton()
        {
            Thread.Sleep(1000);
            GroceryButton.Click();
        }

    }
}
