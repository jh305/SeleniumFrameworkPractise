using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.PageObjects;

namespace SeleniumFrameworkPractise.Pages
{
    public class DataListFilterPage : PageBase
    {
        IWebDriver Driver;

        DataListFilterBlock DataListFilterBlock;
        SearchResultAttendee SearchResultAttendee;

        public DataListFilterPage(IWebDriver driver, DataListFilterBlock dataListFilterBlock) : base(driver)
        {
            this.Driver = driver;
            this.DataListFilterBlock = dataListFilterBlock;
        }

        private IWebElement GetSearchAttendeesInputElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#input-search")));

        public void InputSearchAttendee(string text) =>
            ClearAndSendKeys(GetSearchAttendeesInputElement(), text);

        public void FirstResultInFilterSearch(string text) =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div > div")));

        public void dfsda()
        {
            // Returns our search resutl element
        }

        public SearchResultAttendee returnResultOfSearchObject()
        {
            this.SearchResultAttendee.CompanyName = DataListFilterBlock.ReturnAttendeeCompanyNameText();
            this.SearchResultAttendee.Name = DataListFilterBlock.ReturnAttendeeNameText();
            this.SearchResultAttendee.Title = DataListFilterBlock.ReturnAttendeeTitleText();
            this.SearchResultAttendee.Phone = DataListFilterBlock.ReturnAttendeePhoneText();
            this.SearchResultAttendee.Email = DataListFilterBlock.ReturnAttendeeEmailText();

            return SearchResultAttendee;
        }
    }
}