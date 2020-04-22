﻿using SeleniumFrameworkPractise.Pages;

namespace SeleniumFrameworkPractise.Steps.DemoPageSteps
{
    public class JQueryDropDownSearchSteps
    {
        private JQueryDropDownSearchPage JQueryDropDownSearchDemoPage;
        public JQueryDropDownSearchSteps(JQueryDropDownSearchPage jQueryDropDownSearchDemoPage)
        {
            this.JQueryDropDownSearchDemoPage = jQueryDropDownSearchDemoPage;
        }

        public void ClickCountryDropdown() =>
            JQueryDropDownSearchDemoPage.ClickCountryDropdown();

        public bool DropDownWithSearchBoxTest(string text)
        {
            JQueryDropDownSearchDemoPage.ClickCountryDropdown();
            JQueryDropDownSearchDemoPage.InputCountry(text);

            if (JQueryDropDownSearchDemoPage.ReturnSelectCountryFirstResultText() == text)
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