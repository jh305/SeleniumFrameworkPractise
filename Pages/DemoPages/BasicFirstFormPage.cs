using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class BasicFirstFormPage : PageBase
    {
        IWebDriver Driver;

        public BasicFirstFormPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetEnterMessageInputElement() =>
            WaitAndReturnElement("#user-message");

        private IWebElement GetShowMessageButtonElement() =>
            WaitAndReturnElement("#get-input > button");

        private IWebElement GetYourMessageElement() =>
            WaitAndReturnElement("#display");

        private IWebElement GetEnterAInputElement() =>
            WaitAndReturnElement("#sum1");

        private IWebElement GetEnterBInputElement() =>
            WaitAndReturnElement("#sum2");

        private IWebElement GetGetTotalButtonElement() =>
            WaitAndReturnElement("#gettotal > button");

        private IWebElement GetDisplayValueElement() =>
            WaitAndReturnElement("#displayvalue");

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

        public void ClickGetTotalButton() =>
            GetGetTotalButtonElement().Click();

        public string GetTotalOfInputsText() =>
            GetDisplayValueElement().Text;
    }
}