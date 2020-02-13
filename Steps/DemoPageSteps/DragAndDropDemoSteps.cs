using OpenQA.Selenium;
using SeleniumFrameworkPractise.Pages;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Steps
{
    public class DragAndDropDemoSteps
    {
        DragAndDropPage DragAndDropDemoPage;
        
        public IList<IWebElement> ItemsToDragList;
        public IList<IWebElement> DroppedItemsList;

        public DragAndDropDemoSteps(DragAndDropPage dragAndDropDemoPage)
        {
            this.DragAndDropDemoPage = dragAndDropDemoPage;
        }

        public void DragAndDropAllItems() 
        {
            //Select all item sin the list and save them to an array
            ItemsToDragList = DragAndDropDemoPage.GetAllElementsInItemsToDragList();

            //for each item move it across
            foreach (IWebElement element in ItemsToDragList)
            {
                DragAndDropDemoPage.DragItemAcross(element);

                //check item no longer in items to drag list
                CheckItemsIsNoLongerInItemsToDragList();

                //check item in new list
                DroppedItemsList = DragAndDropDemoPage.GetAllElementsInDroppedItemsList();
                CheckItemIsInItemsList();

            }
        }        

        public void CheckItemIsInItemsList()
        {
        }

        public void CheckItemsIsNoLongerInItemsToDragList()
        {
        }

        public void checkIfThereAreItemsToDrag()
        {
        }

    }
}