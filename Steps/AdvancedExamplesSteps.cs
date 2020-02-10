using SeleniumFrameworkPractise.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFrameworkPractise.Steps
{
    public class AdvancedExamplesSteps
    {
        private AdvancedExamples AdvancedExamples;

        public AdvancedExamplesSteps(AdvancedExamples advancedExamples)
        {
            this.AdvancedExamples = advancedExamples;
        }

        public void ClickDragAndDropLink() =>
            AdvancedExamples.ClickDragAndDropLinkElement();
    }
}