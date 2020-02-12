using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class BasicCheckboxDemoPage : PageBase
    {
        IWebDriver Driver;

        public BasicCheckboxDemoPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetClickOnThisCheckBoxElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#isAgeSelected")));

        private IWebElement GetCheckBoxIsCheckedMessageElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#txtAge")));

        private IWebElement GetCheckAllButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#check1")));

        private IWebElement GetOption1CheckboxElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#easycont > div > div:nth-child(2) > div:nth-child(5) > div:nth-child(2) > div:nth-child(3) > label > input")));

        private IWebElement GetOption2CheckboxElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#easycont > div > div:nth-child(2) > div:nth-child(5) > div:nth-child(2) > div:nth-child(4) > label > input")));

        private IWebElement GetOption3CheckboxElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#easycont > div > div:nth-child(2) > div:nth-child(5) > div:nth-child(2) > div:nth-child(4) > label > input")));

        private IWebElement GetOption4CheckboxElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#easycont > div > div:nth-child(2) > div:nth-child(5) > div:nth-child(2) > div:nth-child(5) > label > input")));

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