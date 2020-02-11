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

        private IWebElement ItemsToDragElement() =>
            Driver.FindElement(By.CssSelector("#todrag"));

        private IWebElement DroppedItemsElement() =>
            Driver.FindElement(By.CssSelector("#droppedlist"));

        private IWebElement DropZoneElement() =>
            Driver.FindElement(By.CssSelector("#mydropzone"));

        public IList<IWebElement> GetAllElementsInItemsToDragList() =>
            ItemsToDragElement().FindElements(By.TagName("span"));

        public IList<IWebElement> GetAllElementsInDroppedItemsList() =>
            DroppedItemsElement().FindElements(By.TagName("span"));

        public void DragItemAcross(IWebElement element)
        {
            //Doesn't work
            Actions.MoveToElement(element);
            Actions.ClickAndHold(element);
            Actions.MoveToElement(DropZoneElement());
            Actions.Release();
            Actions.Perform();

            //Doesn't work
            //Actions.DragAndDrop(element, DropZoneElement()).Build().Perform();
        }
    }
}