using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class BasicExamplesSteps
    {
        private BasicExamples BasicExamples;

        public BasicExamplesSteps(BasicExamples basicExamples)
        {
            this.BasicExamples = basicExamples;
        }

        public void ClickProceedNextButton() =>
            BasicExamples.ClickProceedNextElement();

        public void ClickSimpleFormDemoLink() =>
            BasicExamples.ClickSimpleFormDemoLink();            
    }
}