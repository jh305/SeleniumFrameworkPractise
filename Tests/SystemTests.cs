using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.PageObjects;
using SeleniumFrameworkPractise.Pages;
using SeleniumFrameworkPractise.Steps;
using SeleniumFrameworkPractise.Steps.DemoPageSteps;

namespace SeleniumFrameworkPractise.Tests
{
    [TestFixture]
    public class SystemTests : DriverBase
    {
        [Test]
        [Category("Basic")]
        public void Basic_InputFieldsTest()
        {
            // Arrange
            CreateDriver();
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamplesBlock(Driver)));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamplesBlock(Driver));
            var basicFirstFormDemoSteps = new BasicFirstFormDemoSteps(new BasicFirstFormPage(Driver));
            string expectedText = "This is my string, there are many like it, but this one is mine";
            string notANumber1 = "Sholdnt";
            string notANumber2 = "Work";
            string isANumber1 = "234";
            string isANumber2 = "543";
            string expectedSum = "777";

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickSimpleFormDemoLink();

            // Assert
            using (new AssertionScope())
            {
                basicFirstFormDemoSteps.EnterCharactersAndReturnDisplayedCharacters(expectedText).Should().Be(expectedText);
                basicFirstFormDemoSteps.EnterCharactersAndReturnDisplayedSumOfCharacters(notANumber1, notANumber2).Should().Be("NaN");
                basicFirstFormDemoSteps.EnterCharactersAndReturnDisplayedSumOfCharacters(isANumber1, isANumber2).Should().Be(expectedSum);
            }
        }

        [Test]
        [Category("Basic")]
        public void Basic_CheckBoxTest()
        {
            // Arrange
            CreateDriver();
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamplesBlock(Driver)));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamplesBlock(Driver));
            var basicCheckboxDemoSteps = new BasicCheckboxDemoSteps(new BasicCheckboxPage(Driver));

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickCheckboxDemoLink();

            // Assert
            using (new AssertionScope())
            {
                basicCheckboxDemoSteps.SingleCheckboxTest().Should().BeTrue();
                basicCheckboxDemoSteps.MultipleCheckboxTest().Should().BeTrue();
            }
        }

        [Test]
        [Category("Intermediate")]
        public void Intermediate_DataListFilterTest()
        {
            // Arrange
            CreateDriver();
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamplesBlock(Driver), new IntermediateExamplesBlock(Driver)));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamplesBlock(Driver));
            var intermediateExamplesSteps = new IntermediateExamplesSteps(new IntermediateExamplesBlock(Driver));
            var dataListFilterSteps = new DataListFilterSteps(new DataListFilterPage(Driver, new DataListFilterBlock(Driver)));
            string attendeenName = "Brenda Tree";

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickDataListFilterLink();
            dataListFilterSteps.SearchForAttendee(attendeenName);
            SearchResultAttendee searchResultAttendee = dataListFilterSteps.ExtractAttendeeDataOfFirstSearchResult();            

            // Assert
            using (new AssertionScope())
            {
                searchResultAttendee.CompanyName.Should().Be("Company Name");
                searchResultAttendee.Name.Should().Be("Brenda Tree");
                searchResultAttendee.Title.Should().Be("Manager");
                searchResultAttendee.Phone.Should().Be("644-555-2222");
                searchResultAttendee.Email.Should().Be("test2@company.com");
            }
        }

        [Test]
        [Category("Intermediate")]
        public void Intermediate_JQueryDropDown()
        {
            // Arrange
            CreateDriver();
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamplesBlock(Driver), new IntermediateExamplesBlock(Driver)));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamplesBlock(Driver));
            var intermediateExamplesSteps = new IntermediateExamplesSteps(new IntermediateExamplesBlock(Driver));
            var jQueryropDownSearchDemoSteps = new JQueryropDownSearchDemoSteps(new JQueryDropDownSearchPage(Driver));

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickJQuerySelectDropDownLink();

            // Assert
            using (new AssertionScope())
            {
                jQueryropDownSearchDemoSteps.DropDownWithSearchBoxTest("Denmark").Should().BeTrue();
            }
        }

        [Test]
        [Category("Advanced")]
        public void Advanced_DragAndDropTest()
        {
            // Arrange
            CreateDriver();
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamplesBlock(Driver), new IntermediateExamplesBlock(Driver), new AdvancedExamplesBlock(Driver)));
            var dragAndDropDemoSteps = new DragAndDropDemoSteps(new DragAndDropPage(Driver));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamplesBlock(Driver));
            var intermediateExamplesSteps = new IntermediateExamplesSteps(new IntermediateExamplesBlock(Driver));
            var advancedExamplesSteps = new AdvancedExamplesSteps(new AdvancedExamplesBlock(Driver));

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickProceedNextButton();
            advancedExamplesSteps.ClickDragAndDropLink();
            dragAndDropDemoSteps.DragAndDropAllItems();
        }

        [Test]
        [Category("Advanced")]
        public void Advanced_DragAndDropSlidersTest()
        {
            // Arrange
            CreateDriver();
            var homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamplesBlock(Driver), new IntermediateExamplesBlock(Driver), new AdvancedExamplesBlock(Driver)));
            var basicExamplesSteps = new BasicExamplesSteps(new BasicExamplesBlock(Driver));
            var intermediateExamplesSteps = new IntermediateExamplesSteps(new IntermediateExamplesBlock(Driver));
            var advancedExamplesSteps = new AdvancedExamplesSteps(new AdvancedExamplesBlock(Driver));
            var dragAndDropRangeSlidersSteps = new DragAndDropRangeSlidersSteps(new Pages.DemoPages.DragAndDropRangeSlidersPage(Driver));

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickProceedNextButton();
            advancedExamplesSteps.ClickDragAndDropSlidersLink();

            using (new AssertionScope())
            {
                dragAndDropRangeSlidersSteps.GetSlider1DefaultText().Should().Be("10");
                dragAndDropRangeSlidersSteps.GetSlider1CurrentRangeText().Should().Be("10");
                // ADD ASSERT WHICH MOVES SLIDER
            }
        }
    }
}