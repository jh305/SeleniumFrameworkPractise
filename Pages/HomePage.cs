using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class HomePage : PageBase
    {
        IWebDriver Driver;

        public HomePage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        public void NavigateToURL() =>
            Driver.Url = "https://www.bbc.co.uk/";
    }
}