using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Pages
{
    public class DragAndDropDemoPage : PageBase
    {
        public IWebDriver Driver;        

        public DragAndDropDemoPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetItemsToDragElement() =>
            Driver.FindElement(By.CssSelector("#todrag"));

        private IWebElement GetDroppedItemsElement() =>
            Driver.FindElement(By.CssSelector("#droppedlist"));

        private IWebElement GetDropZoneElement() =>
            Driver.FindElement(By.CssSelector("#mydropzone"));

        public IList<IWebElement> GetAllElementsInItemsToDragList() =>
            GetItemsToDragElement().FindElements(By.TagName("span"));

        public IList<IWebElement> GetAllElementsInDroppedItemsList() =>
            GetDroppedItemsElement().FindElements(By.TagName("span"));

        public void DragItemAcross(IWebElement element)
        {
            //Doesn't work
            Actions.MoveToElement(element);
            Actions.ClickAndHold(element);
            Actions.MoveToElement(GetDropZoneElement());
            Actions.Release();
            Actions.Perform();

            //Doesn't work
            //Actions.DragAndDrop(element, DropZoneElement()).Build().Perform();
        }
    }
}