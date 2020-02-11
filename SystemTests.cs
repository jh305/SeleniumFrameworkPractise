﻿using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.Pages;
using SeleniumFrameworkPractise.Steps;

namespace SeleniumFrameworkPractise
{
    [TestFixture]
    public class SystemTests : DriverBase
    {
        [Test]
        public void Advanced_DragAndDropTest()
        {
            // Arrange
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamples(Driver), new IntermediateExamples(Driver), new AdvancedExamples(Driver)));
            var dragAndDropDemoSteps = new DragAndDropDemoSteps(new DragAndDropDemoPage(Driver));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamples(Driver));
            var intermediateExamplesSteps = new IntermediateExamplesSteps(new IntermediateExamples(Driver));
            var advancedExamplesSteps = new AdvancedExamplesSteps(new AdvancedExamples(Driver));

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickProceedNextButton();
            advancedExamplesSteps.ClickDragAndDropLink();
            dragAndDropDemoSteps.DragAndDropAllItems();
        }

        [Test]
        public void Basic_InputFieldsTest()
        {          
            // Arrange
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamples(Driver)));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamples(Driver));
            var basicFirstFormDemoSteps = new BasicFirstFormDemoSteps(new BasicFirstFormDemoPage(Driver));
            string expectedText = "This is my string, there are many like it, but this one is mine";
            string notANumber1 = "Shpldnt";
            string notANumber2 = "Work";
            string isANumber1 = "234";
            string isANumber2 = "543";
            string expectedSum = "777";

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickSimpleFormDemoLink();

            using (new AssertionScope())
            {
                basicFirstFormDemoSteps.EnterCharactersAndReturnDisplayedCharacters(expectedText).Should().Be(expectedText);
                basicFirstFormDemoSteps.EnterCharactersAndReturnDisplayedSumOfCharacters(notANumber1, notANumber2).Should().Be("NaN");
                basicFirstFormDemoSteps.EnterCharactersAndReturnDisplayedSumOfCharacters(isANumber1, isANumber2).Should().Be(expectedSum);
            }
        }

        [Test]
        public void Intermediate_DataListFilterTest()
        {
            // Arrange
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamples(Driver), new IntermediateExamples(Driver)));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamples(Driver));
            var intermediateExamplesSteps = new IntermediateExamplesSteps(new IntermediateExamples(Driver));

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickDataListFilterLink();

            using (new AssertionScope())
            {

            }

        }
    }
}