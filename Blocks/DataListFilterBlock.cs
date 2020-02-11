using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class DataListFilterBlock : BlockBase
    {
        IWebDriver Driver;

        public DataListFilterBlock(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement FirstResultInFilterSearch() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div")));

        private IWebElement GetAttendeeCompanyNameElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div:nth-child(1) > div > h5")));

        private IWebElement GetAttendeeNameElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div > h4")));

        private IWebElement GetAttendeeTitleElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div > p")));

        private IWebElement GetAttendeePhoneElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div > span:nth-child(5)")));

        private IWebElement GetAttendeeEmailElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div > span:nth-child(6)")));

        public string ReturnAttendeeCompanyNameText() =>
            GetAttendeeCompanyNameElement().Text;

        public string ReturnAttendeeNameText() =>
            GetAttendeeNameElement().Text;

        public string ReturnAttendeeTitleText() =>
            GetAttendeeTitleElement().Text;

        public string ReturnAttendeePhoneText() =>
            GetAttendeePhoneElement().Text;

        public string ReturnAttendeeEmailText() =>
            GetAttendeeEmailElement().Text;
    }
}