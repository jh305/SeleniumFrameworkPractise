﻿using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class IntermediateExamplesBlock : BlockBase
    {
        IWebDriver Driver;

        public IntermediateExamplesBlock(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        IWebElement GetProceedNextButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_advanced_example")));

        IWebElement GetDataListFilterLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#intermediate > div > a:nth-child(6)")));

        IWebElement GetJQuerySelectDropDownLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#intermediate > div > a:nth-child(3)")));

        public void ClickProceedNextButton()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetProceedNextButtonElement()));

            ScrollElementIntoView(GetProceedNextButtonElement());
            GetProceedNextButtonElement().Click();
        }

        public void ClickDataListFilterLink()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetDataListFilterLinkElement()));

            ScrollElementIntoView(GetDataListFilterLinkElement());
            GetDataListFilterLinkElement().Click();
        }

        public void ClickJQuerySelectDropDownLink()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetJQuerySelectDropDownLinkElement()));

            ScrollElementIntoView(GetJQuerySelectDropDownLinkElement());
            GetJQuerySelectDropDownLinkElement().Click();
        }
    }
}