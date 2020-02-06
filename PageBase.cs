using OpenQA.Selenium;

namespace SeleniumFrameworkPractise
{
    public class PageBase
    {
        private IWebDriver Driver;
        
        public PageBase(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}