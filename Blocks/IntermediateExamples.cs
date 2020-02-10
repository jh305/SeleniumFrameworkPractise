using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class IntermediateExamples : BlockBase
    {
        IWebDriver Driver;

        public IntermediateExamples(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        IWebElement GetProceedNextButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_advanced_example")));

        public void ClickProceedNextElement()
        {
            ScrollElementIntoView(GetProceedNextButtonElement());
            GetProceedNextButtonElement().Click();
        }
    }
}