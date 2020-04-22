using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.PageObjects;
using SeleniumFrameworkPractise.Pages;
using SeleniumFrameworkPractise.Pages.DemoPages;
using SeleniumFrameworkPractise.Steps;
using SeleniumFrameworkPractise.Steps.DemoPageSteps;

namespace SeleniumFrameworkPractise.Tests
{
    [TestFixture]
    public class SystemTests : DriverBase
    {
        public HomePageSteps homePageSteps;
        public BasicExamplesSteps basicExamplesSteps;
        public BasicFirstFormSteps basicFirstFormSteps;
        public IntermediateExamplesSteps intermediateExamplesSteps;
        public DataListFilterSteps dataListFilterSteps;
        public BasicCheckboxSteps basicCheckboxSteps;
        public JQueryDropDownSearchSteps jQueryropDownSearchSteps;
        public AdvancedExamplesSteps advancedExamplesSteps;
        public DragAndDropSteps dragAndDropSteps;
        public DragAndDropRangeSlidersSteps dragAndDropRangeSlidersSteps;

    [SetUp]
        public void TestStup()
        {
            CreateDriver();

            homePageSteps = new HomePageSteps(new HomePage(Driver, new BasicExamplesBlock(Driver), new IntermediateExamplesBlock(Driver)));
            basicExamplesSteps = new BasicExamplesSteps(new BasicExamplesBlock(Driver));
            basicFirstFormSteps = new BasicFirstFormSteps(new BasicFirstFormPage(Driver));
            basicCheckboxSteps = new BasicCheckboxSteps(new BasicCheckboxPage(Driver));
            intermediateExamplesSteps = new IntermediateExamplesSteps(new IntermediateExamplesBlock(Driver));
            dataListFilterSteps = new DataListFilterSteps(new DataListFilterPage(Driver, new DataListFilterBlock(Driver)));
            jQueryropDownSearchSteps = new JQueryDropDownSearchSteps(new JQueryDropDownSearchPage(Driver));
            advancedExamplesSteps = new AdvancedExamplesSteps(new AdvancedExamplesBlock(Driver));
            dragAndDropSteps = new DragAndDropSteps(new DragAndDropPage(Driver));
            dragAndDropRangeSlidersSteps = new DragAndDropRangeSlidersSteps(new DragAndDropRangeSlidersPage(Driver));
        }

        [Test]
        [Category("Basic")]
        public void Basic_InputFieldsTest()
        {
            // Arrange
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
                basicFirstFormSteps.EnterCharactersAndReturnDisplayedCharacters(expectedText).Should().Be(expectedText);
                basicFirstFormSteps.EnterCharactersAndReturnDisplayedSumOfCharacters(notANumber1, notANumber2).Should().Be("NaN");
                basicFirstFormSteps.EnterCharactersAndReturnDisplayedSumOfCharacters(isANumber1, isANumber2).Should().Be(expectedSum);
            }
        }

        [Test]
        [Category("Basic")]
        public void Basic_CheckBoxTest()
        {
            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickCheckboxDemoLink();

            // Assert
            using (new AssertionScope())
            {
                basicCheckboxSteps.SingleCheckboxTest().Should().BeTrue();
                basicCheckboxSteps.MultipleCheckboxTest().Should().BeTrue();
            }
        }

        [Test]
        [Category("Intermediate")]
        public void Intermediate_DataListFilterTest()
        {
            // Arrange
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
            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickJQuerySelectDropDownLink();

            // Assert
            using (new AssertionScope())
            {
                jQueryropDownSearchSteps.DropDownWithSearchBoxTest("Denmark").Should().BeTrue();
            }
        }

        [Test]
        [Category("Advanced")]
        public void Advanced_DragAndDropTest()
        {
            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickProceedNextButton();
            advancedExamplesSteps.ClickDragAndDropLink();
            dragAndDropSteps.DragAndDropAllItems();
        }

        [Test]
        [Category("Advanced")]
        public void Advanced_DragAndDropSlidersTest()
        {
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