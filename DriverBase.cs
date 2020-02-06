using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumFrameworkPractise
{
    public class DriverBase
    {
        private IWebDriver Driver;
        
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
