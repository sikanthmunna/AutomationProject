using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.Events;
using System.Threading.Tasks;

namespace NewJobProject.Source.Pages
{
    public class Homepage
    {
        
        private IWebDriver _driver;
        private IWebElement SearchBox => _driver.FindElement(By.Id("twotabsearchtextbox"));
        private IWebElement SearchButton => _driver.FindElement(By.Id("nav-search-submit-button"));
        private IWebElement GroceryButton => _driver.FindElement(By.Id("nav-link-groceries"));
        private IWebElement TodayDeals => _driver.FindElement(By.ClassName("nav-a"));
        private IWebElement AllMenuButton => _driver.FindElement(By.Id("nav-hamburger-menu"));
        private IWebElement MenuList => _driver.FindElement(By.Id("hmenu-content"));
        private IWebElement SignInButton => _driver.FindElement(By.Id("nav-link-accountList-nav-line-1"));
        private IWebElement SignInTitle => _driver.FindElement(By.XPath("//h1[normalize-space()='Sign in']"));
        private IWebElement EmailTextBox => _driver.FindElement(By.Id("ap_email"));

        

        
        


        public Homepage(IWebDriver driver)
        {
            _driver = driver;

        }


        public void EnterSerachBox(string data)
        {
            SearchBox.SendKeys(data);
        }

        public void ClickSearchButton() => SearchButton.Click();
        public void ClickTodayDealsButton() => TodayDeals.Click();
        public void ClikcAllMenuButton() => AllMenuButton.Click();
        public void ClikcSignInButton() => SignInButton.Click();
        public string SignInText => SignInTitle.Text;

        public void ClickGroceryButton()
        {
            Thread.Sleep(1000);
            GroceryButton.Click();
        }

        public bool MenuListDisplayed => MenuList.Displayed;
        public bool EmailTextBoxDisplayed => EmailTextBox.Displayed;

        

    }
}
