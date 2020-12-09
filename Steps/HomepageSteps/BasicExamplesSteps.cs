using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class BasicExamplesSteps
    {
        private BasicExamplesBlock _basicExamplesBlock;

        public BasicExamplesSteps(BasicExamplesBlock basicExamplesBlock)
        {
            this._basicExamplesBlock = basicExamplesBlock;
        }

        public void ClickProceedNextButton() =>
            _basicExamplesBlock.ClickProceedNextElement();

        public void ClickSimpleFormDemoLink() =>
            _basicExamplesBlock.ClickSimpleFormDemoLink();

        public void ClickCheckboxDemoLink() =>
            _basicExamplesBlock.ClickCheckboxDemoLink();
    }
}