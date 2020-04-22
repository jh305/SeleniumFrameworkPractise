using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class JQueryDropDownSearchPage : PageBase
    {
        IWebDriver Driver;
        public JQueryDropDownSearchPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }
        private IWebElement GetCountryDropDownElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("body > div.container-fluid.text-center > div > div.col-md-6.text-left > div:nth-child(2) > div > div.panel-body > span"))); //NEED TO CHANGE!!!

        private IWebElement GetCountryDropDownSearchElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("body > span > span > span.select2-search.select2-search--dropdown > input")));

        private IWebElement GetSelectCountryFirstResultElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#select2-country-results > li")));        

        public void ClickCountryDropdown() =>
            GetCountryDropDownElement().Click();

        public void InputCountry(string text) =>
            ClearAndSendKeys(GetCountryDropDownSearchElement(), text);

        public string ReturnSelectCountryFirstResultText() =>
            GetSelectCountryFirstResultElement().Text;
    }
}