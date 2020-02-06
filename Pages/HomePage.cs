using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class HomePage : PageBase
    {
        private IWebDriver Driver;

        public HomePage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        IWebElement GetStartPractisingButtonElement() =>
            Driver.FindElement(By.CssSelector("#btn_basic_example"));

        public void ClickStartPractisingButton() =>
            GetStartPractisingButtonElement().Click();

        public void NavigateToURL() =>
            Driver.Url = "https://www.seleniumeasy.com/test/";
    }
}