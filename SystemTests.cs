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
        public void DragAndDropTest()
        {
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamples(Driver), new IntermediateExamples(Driver), new AdvancedExamples(Driver)));
            var dragAndDropDemoSteps = new DragAndDropDemoSteps(new DragAndDropDemoPage(Driver));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamples(Driver));
            var intermediateExamplesSteps = new IntermediateExamplesSteps(new IntermediateExamples(Driver));
            var advancedExamplesSteps = new AdvancedExamplesSteps(new AdvancedExamples(Driver));

            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickProceedNextButton();
            advancedExamplesSteps.ClickDragAndDropLink();

            dragAndDropDemoSteps.DragAndDropAllItems();


        }
    }
}