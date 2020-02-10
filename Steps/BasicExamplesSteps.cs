using SeleniumFrameworkPractise.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFrameworkPractise.Steps
{
    public class BasicExamplesSteps
    {
        private BasicExamples BasicExamples;

        public BasicExamplesSteps(BasicExamples basicExamples)
        {
            this.BasicExamples = basicExamples;
        }

        public void ClickProceedNextButton()
        {        
            
            BasicExamples.ClickProceedNextElement();

        }
            
    }
}
