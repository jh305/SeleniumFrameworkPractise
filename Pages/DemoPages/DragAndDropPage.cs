using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Pages
{
    public class DragAndDropPage : PageBase
    {
        public IWebDriver Driver;        

        public DragAndDropPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetItemsToDragElement() =>
            WaitAndReturnElement("#todrag");

        private IWebElement GetDroppedItemsElement() =>
            WaitAndReturnElement("#droppedlist");

        private IWebElement GetDropZoneElement() =>
            WaitAndReturnElement("mydropzone");

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