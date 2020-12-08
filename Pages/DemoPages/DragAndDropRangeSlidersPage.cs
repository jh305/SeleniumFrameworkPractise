using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages.DemoPages
{
    public class DragAndDropRangeSlidersPage : PageBase
    {
        IWebDriver Driver;

        public DragAndDropRangeSlidersPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetSlider1DefaultValueElement() =>
            WaitAndReturnElement("#slider1 > h4");

        private IWebElement GetSlider1CurrentRangeElement() =>
            WaitAndReturnElement("#slider1 > div.range > output#range");

        public string GetSlider1DefaultValueText() =>
            GetSlider1DefaultValueElement().Text.Substring(14);

        public string GetSlider1CurrentRangeText() =>
            GetSlider1CurrentRangeElement().Text;
    }
}