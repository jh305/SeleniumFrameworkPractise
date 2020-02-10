using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFrameworkPractise.Steps
{
    public class IntermediateExamplesSteps
    {
        IntermediateExamples IntermediateExamples;

        public IntermediateExamplesSteps(IntermediateExamples intermediateExamples)
        {
            this.IntermediateExamples = intermediateExamples;
        }

        public void ClickProceedNextButton() =>
            IntermediateExamples.ClickProceedNextElement();
    }
}
