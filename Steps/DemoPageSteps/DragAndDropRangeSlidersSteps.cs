using SeleniumFrameworkPractise.Pages.DemoPages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFrameworkPractise.Steps.DemoPageSteps
{
    public class DragAndDropRangeSlidersSteps
    {
        private DragAndDropRangeSlidersPage DragAndDropRangeSlidersPage;

        public DragAndDropRangeSlidersSteps(DragAndDropRangeSlidersPage dragAndDropRangeSlidersPage)
        {
            this.DragAndDropRangeSlidersPage = dragAndDropRangeSlidersPage;
        }

        public string GetSlider1DefaultText() =>
            DragAndDropRangeSlidersPage.GetSlider1DefaultValueText();

        public string GetSlider1CurrentRangeText() =>
            DragAndDropRangeSlidersPage.GetSlider1CurrentRangeText();
    }
}