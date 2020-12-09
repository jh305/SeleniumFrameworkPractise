using OpenQA.Selenium;
using SeleniumFrameworkPractise.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumFrameworkPractise.Blocks
{
    public class DataListFilterBlock : BlockBase
    {
        private IWebDriver _driver;

        private List<SearchResultAttendee> _searchResults;

        public DataListFilterBlock(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
            this._searchResults = new List<SearchResultAttendee>();
        }

        private IWebElement GetSearchResultsElement() =>
            WaitAndReturnElement("body > div.container-fluid.text-center > div > div.col-md-6.text-left > section > div > div.searchable-container");

        public List<SearchResultAttendee> ExtractVisibleResultsFromSearchTable()
        {
            try
            {
                //get search results element
                IWebElement SearchResultsElement = GetSearchResultsElement();

                //Extract Results From SearchTable
                ReadOnlyCollection<IWebElement> SearchResultElements = SearchResultsElement.FindElements(By.TagName("div"));

                //Extract visible Results From SearchTable
                List<IWebElement> VisibleResultElements = new List<IWebElement>();
                foreach (IWebElement element in SearchResultElements)
                {
                    //Put them into a list if they are visible
                    if (element.GetAttribute("style") == "display: block;")
                    {
                        VisibleResultElements.Add(element);
                    }
                }

                //extract values from search result, create attendee object and return list of attendee objects
                foreach (IWebElement element in VisibleResultElements)
                {
                    _searchResults.Add(new SearchResultAttendee()
                    {
                        CompanyName = element.FindElement(By.TagName("h5")).Text,
                        Name = element.FindElement(By.TagName("h4")).Text,
                        Title = element.FindElement(By.TagName("p")).Text,
                        Phone = "", //Both phone and email use the same tag name so we can't search by tag name damn it!!
                        Email = ""   //How can we identitfy which is which if they are both the same??!?!??!
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