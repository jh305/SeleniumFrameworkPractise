using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class BasicFirstFormPage : PageBase
    {
        private IWebDriver Driver;

        public BasicFirstFormPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetEnterMessageInputElement() =>
            Driver.FindElement(By.CssSelector("#user-message"));

        private IWebElement GetShowMessageButtonElement() =>
            Driver.FindElement(By.CssSelector("#get-input > button"));

        private IWebElement GetYourMessageElement() =>
            Driver.FindElement(By.CssSelector("#display"));

        private IWebElement GetEnterAInputElement() =>
            Driver.FindElement(By.CssSelector("#sum1"));

        private IWebElement GetEnterBInputElement() =>
            Driver.FindElement(By.CssSelector("#sum2"));

        private IWebElement GetGetTotalButtonElement() =>
            Driver.FindElement(By.CssSelector("#gettotal > button"));

        private IWebElement GetDisplayValueElement() =>
            Driver.FindElement(By.CssSelector("#displayvalue"));

        public void InputMessage(string text) =>
            ClearAndSendKeys(GetEnterMessageInputElement(), text);

        public void ClickShowMessageButton() =>
            GetShowMessageButtonElement().Click();

        public string GetYourMessageText() =>
            GetYourMessageElement().Text;

        public void InputCharactersIntoInputA(string text) =>
            ClearAndSendKeys(GetEnterAInputElement(), text);

        public void InputCharactersIntoInputB(string text) =>
            ClearAndSendKeys(GetEnterBInputElement(), text);

        public void ClickGetTotalButton()
        {
            try
            {
                GetGetTotalButtonElement().Click();
            }
            catch (ElementClickInterceptedException)
            {
                ClosePopupWindow();
                GetGetTotalButtonElement().Click();
            }
        }

        public string GetTotalOfInputsText() =>
            GetDisplayValueElement().Text;
    }
}