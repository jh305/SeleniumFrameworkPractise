using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class JQueryDropDownSearchDemoPage : PageBase
    {
        IWebDriver Driver;
        public JQueryDropDownSearchDemoPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }
        private IWebElement GetCountryDropDownElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("")));

        private IWebElement GetCountryDropDownSearchElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".select2-search select2-search--dropdown > input")));

        private IWebElement GetElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("")));

        public void ClickCountryDropdown() =>
            GetCountryDropDownElement().Click();

        public void InputCountry(string text) =>
            ClearAndSendKeys(GetCountryDropDownSearchElement(), text);
    }
}