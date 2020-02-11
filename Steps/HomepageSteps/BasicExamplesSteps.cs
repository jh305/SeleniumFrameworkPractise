using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class BasicExamplesSteps
    {
        private BasicExamplesBlock BasicExamplesBlock;

        public BasicExamplesSteps(BasicExamplesBlock basicExamplesBlock)
        {
            this.BasicExamplesBlock = basicExamplesBlock;
        }

        public void ClickProceedNextButton() =>
            BasicExamplesBlock.ClickProceedNextElement();

        public void ClickSimpleFormDemoLink() =>
            BasicExamplesBlock.ClickSimpleFormDemoLink();            
    }
}