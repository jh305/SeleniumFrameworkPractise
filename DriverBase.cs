using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumFrameworkPractise
{
    public class DriverBase
    {
        public IWebDriver Driver;

        public DriverBase()
        {
            this.Driver = new ChromeDriver();
        }        

        [TearDown]
        public void Cleanup()
        {
            if (this.Driver != null)
            {
                this.Driver.Quit();
                this.Driver.Dispose();
                this.Driver = null;
            }
        }
    }
}