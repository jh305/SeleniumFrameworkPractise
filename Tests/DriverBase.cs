using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFrameworkPractise
{
    public class DriverBase
    {
        public IWebDriver Driver;   

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

        public void CreateDriver()
        {
            this.Driver = new ChromeDriver();
        }

        //TODO
        public void RunPowershellCleanupDriverScript()
        {
         //This script will kill any driver procesess if test is interuppted
         //It will be called from the Cleanup method above
        }
    }
}