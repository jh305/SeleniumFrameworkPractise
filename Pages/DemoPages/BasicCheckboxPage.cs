using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class BasicCheckboxPage : PageBase
    {
        IWebDriver Driver;

        public BasicCheckboxPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetClickOnThisCheckBoxElement() =>
            WaitAndReturnElement("#isAgeSelected");

        private IWebElement GetCheckBoxIsCheckedMessageElement() =>
            WaitAndReturnElement("#txtAge");

        private IWebElement GetCheckAllButtonElement() =>
            WaitAndReturnElement("#check1");

        private IWebElement GetOption1CheckboxElement() =>
            WaitAndReturnElement("#easycont > div > div:nth-child(2) > div:nth-child(5) > div:nth-child(2) > div:nth-child(3) > label > input");

        private IWebElement GetOption2CheckboxElement() =>
            WaitAndReturnElement("#easycont > div > div:nth-child(2) > div:nth-child(5) > div:nth-child(2) > div:nth-child(4) > label > input");

        private IWebElement GetOption3CheckboxElement() =>
            WaitAndReturnElement("#easycont > div > div:nth-child(2) > div:nth-child(5) > div:nth-child(2) > div:nth-child(4) > label > input");

        private IWebElement GetOption4CheckboxElement() =>
            WaitAndReturnElement("#easycont > div > div:nth-child(2) > div:nth-child(5) > div:nth-child(2) > div:nth-child(5) > label > input");

        public void ClickCheckAllButton() =>
            GetCheckAllButtonElement().Click();

        public bool SelectSingleCheckbox()
        {
            if (!GetClickOnThisCheckBoxElement().Selected)
            {
                GetClickOnThisCheckBoxElement().Click();
                return true;
            }
            else
            {
                // TODO Create custom error which prints out failures.
                return false;
            }
        }

        public void DeselectSingleCheckbout()
        {
            if (GetClickOnThisCheckBoxElement().Selected)
            {
                GetClickOnThisCheckBoxElement().Click();
            }
            else
            {
                // TODO Create custom error which prints out failures
            }
        }

        public bool CheckboxIsCheckedSuccessMessageStatus()
        {
            if (GetCheckBoxIsCheckedMessageElement().Text == "Success - Check box is checked") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckAllOptionCheckboxesAreChecked()
        {
            if (GetOption1CheckboxElement().Selected &&
                GetOption2CheckboxElement().Selected &&
                GetOption3CheckboxElement().Selected &&
                GetOption4CheckboxElement().Selected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}