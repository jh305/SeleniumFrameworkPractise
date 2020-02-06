using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class HomePage : PageBase
    {
        private IWebDriver Driver;

        public HomePage(IWebDriver driver) : base(driver)
        {
        }
    }
}