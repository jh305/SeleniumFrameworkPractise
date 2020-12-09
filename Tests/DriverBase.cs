using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFrameworkPractise
{
    public class DriverBase
    {
        public IWebDriver _driver;   

        [TearDown]
        public void Cleanup()
        {
            if (this._driver != null)
            {
                this._driver.Quit();
                this._driver.Dispose();
                this._driver = null;
            }
        }

        public void CreateDriver()
        {
            this._driver = new ChromeDriver();
        }

        //TODO
        public void RunPowershellCleanupDriverScript()
        {
         //This script will kill any driver procesess if test is interuppted
         //It will be called from the Cleanup method above
        }
    }
}