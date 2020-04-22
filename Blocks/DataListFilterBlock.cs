using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFrameworkPractise.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;

namespace SeleniumFrameworkPractise.Blocks
{
    public class DataListFilterBlock : BlockBase
    {
        IWebDriver Driver;

        private List<SearchResultAttendee> SearchResults;

        public DataListFilterBlock(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
            this.SearchResults = new List<SearchResultAttendee>();
        }

        private IWebElement FirstResultInFilterSearch() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div")));

        private IWebElement GetAttendeeCompanyNameElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div:nth-child(1) > div > h5")));

        private IWebElement GetAttendeeNameElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div > h4")));

        private IWebElement GetAttendeeTitleElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div > p")));

        private IWebElement GetAttendeePhoneElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div > span:nth-child(5)")));

        private IWebElement GetAttendeeEmailElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector(".searchable-container > div > div > span:nth-child(6)")));

        private IWebElement GetSearchResultsElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("body > div.container-fluid.text-center > div > div.col-md-6.text-left > section > div > div.searchable-container")));

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
                    SearchResults.Add(new SearchResultAttendee()
                    {
                        CompanyName = element.FindElement(By.TagName("h5")).Text,
                        Name = element.FindElement(By.TagName("h4")).Text,
                        Title = element.FindElement(By.TagName("p")).Text,
                        Phone = "", //Both phone and emal use the same tag name so we can't search by tag name damn it!!
                        Email = ""   //How can we identitfy which is which if they are both the same??!?!??!
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