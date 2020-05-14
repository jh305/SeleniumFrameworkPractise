using OpenQA.Selenium;
using SeleniumFrameworkPractise.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumFrameworkPractise.Blocks
{
    public class TableDataSearchBlock : BlockBase
    {
        private IWebDriver Driver;
        private List<SearchResultTask> SearchResults;

        public TableDataSearchBlock(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
            this.SearchResults = new List<SearchResultTask>();
        }

        private IWebElement GetTasksInputFieldElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#task-table-filter")));

        private IWebElement GetTableSearchResultsElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#task-table > tbody")));

        public void EnterTextIntoTasksInputField(string text)
        {
            GetTasksInputFieldElement().Click();
            ClearAndSendKeys(GetTasksInputFieldElement(), text);
            GetTasksInputFieldElement().Click();
        }
            

        public List<SearchResultTask> ExtractVisibleResultsFromSearchTable()
        {
            try
            {
                Wait.Until(Driver => (bool)((IJavaScriptExecutor)Driver).ExecuteScript("return jQuery.active == 0"));

                //get search results element
                IWebElement SearchResultsElement = GetTableSearchResultsElement();

                //Extract Results From SearchTable
                ReadOnlyCollection<IWebElement> SearchResultElements = SearchResultsElement.FindElements(By.TagName("tr"));

                //Extract visible Results From SearchTable
                List<IWebElement> VisibleResultElements = new List<IWebElement>();
                foreach (IWebElement element in SearchResultElements)
                {
                    //Put them into a list if they are visible
                    if (element.GetAttribute("style") != "display: none;")
                    {
                        VisibleResultElements.Add(element);
                    }
                }

                //extract values from search result, create attendee object and return list of attendee objects
                foreach (IWebElement element in VisibleResultElements)
                {
                    ReadOnlyCollection<IWebElement> SearchResultValues = element.FindElements(By.TagName("td"));

                    SearchResults.Add(new SearchResultTask()
                    {
                        Number = SearchResultValues[0].Text,
                        Name = SearchResultValues[1].Text,
                        Assignee = SearchResultValues[2].Text,
                        Status = SearchResultValues[3].Text
                    });
                }

                return SearchResults;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
} 