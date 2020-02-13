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
            Wait.Until(d => d.FindElement(By.CssSelector("div[class=select2 select2-container select2-container--default select2-container--below]"))); //NEED TO CHANGE!!!

        private IWebElement GetCountryDropDownSearchElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".select2-search select2-search--dropdown > input")));

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