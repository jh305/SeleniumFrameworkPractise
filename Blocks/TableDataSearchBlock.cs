using OpenQA.Selenium;
using SeleniumFrameworkPractise.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumFrameworkPractise.Blocks
{
    public class TableDataSearchBlock : BlockBase
    {
        private IWebDriver _driver;
        private List<SearchResultTask> _searchResults;

        public TableDataSearchBlock(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
            this._searchResults = new List<SearchResultTask>();
        }

        private IWebElement GetTasksInputFieldElement() =>
            WaitAndReturnElement("#task-table-filter");

        private IWebElement GetTableSearchResultsElement() =>
            WaitAndReturnElement("#task-table > tbody");

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
                _wait.Until(Driver => (bool)((IJavaScriptExecutor)Driver).ExecuteScript("return jQuery.active == 0"));

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

                    _searchResults.Add(new SearchResultTask()
                    {
                        Number = SearchResultValues[0].Text,
                        Name = SearchResultValues[1].Text,
                        Assignee = SearchResultValues[2].Text,
                        Status = SearchResultValues[3].Text
                    });
                }

                return _searchResults;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
} 