using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class BasicExamples : BlockBase
    {
        IWebDriver Driver;
        public BasicExamples(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }
        IWebElement GetProceedNextButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_inter_example")));    
        
        public void ClickProceedNextElement()
        {
            ScrollElementIntoView(GetProceedNextButtonElement());
            GetProceedNextButtonElement().Click();
        }
    }
}