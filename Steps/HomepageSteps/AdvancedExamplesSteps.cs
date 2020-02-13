using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class AdvancedExamplesSteps
    {
        private AdvancedExamplesBlock AdvancedExamplesBlock;

        public AdvancedExamplesSteps(AdvancedExamplesBlock advancedExamplesBlock)
        {
            this.AdvancedExamplesBlock = advancedExamplesBlock;
        }

        public void ClickDragAndDropLink() =>
            AdvancedExamplesBlock.ClickDragAndDropLinkElement();

        public void ClickDragAndDropSlidersLink() =>
            AdvancedExamplesBlock.ClickDragAndDropSlidersLinkElement();
    }
}