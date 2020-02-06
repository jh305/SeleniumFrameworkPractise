using OpenQA.Selenium;

namespace SeleniumFrameworkPractise
{
    public class PageBase
    {
        public IWebDriver Driver;
        
        public PageBase(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}