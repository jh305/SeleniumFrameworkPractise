using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFrameworkPractise.Shared;

namespace SeleniumFrameworkPractise
{
    public class PopupBase : SharedToolsBase
    {
        private IWebDriver driver;

        public PopupBase(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
    }
}