using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.PageObjects;
using SeleniumFrameworkPractise.Pages;
using SeleniumFrameworkPractise.Pages.DemoPages;
using SeleniumFrameworkPractise.Steps;
using SeleniumFrameworkPractise.Steps.DemoPageSteps;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Tests
{
    [TestFixture]
    public class SystemTests : DriverBase
    {
        public HomePageSteps homePageSteps;
        public BasicExamplesSteps basicExamplesSteps;
        public BasicFirstFormSteps basicFirstFormSteps;
        public IntermediateExamplesSteps intermediateExamplesSteps;
        public AdvancedExamplesSteps advancedExamplesSteps;
        public DataListFilterSteps dataListFilterSteps;
        public TableDataSearchSteps tableDataSearchSteps;

    [SetUp]
        public void TestSetup()
        {
            CreateDriver();

            homePageSteps = new HomePageSteps(new Homepage(Driver, new BasicExamplesBlock(Driver), new IntermediateExamplesBlock(Driver)));
            basicExamplesSteps = new BasicExamplesSteps(new BasicExamplesBlock(Driver));
            basicFirstFormSteps = new BasicFirstFormSteps(new BasicFirstFormPage(Driver));
            intermediateExamplesSteps = new IntermediateExamplesSteps(new IntermediateExamplesBlock(Driver));
            dataListFilterSteps = new DataListFilterSteps(new DataListFilterPage(Driver, new DataListFilterBlock(Driver)));
            advancedExamplesSteps = new AdvancedExamplesSteps(new AdvancedExamplesBlock(Driver));
            tableDataSearchSteps = new TableDataSearchSteps(new TableDataSearchPage(Driver));
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
            List<SearchResultAttendee> SearchResultsAttendeesList = dataListFilterSteps.getResults();           

            // Assert
            using (new AssertionScope())
            {
                SearchResultsAttendeesList.Count.Should().Be(1);
                SearchResultsAttendeesList[0].CompanyName.Should().Be("Company Name");
                SearchResultsAttendeesList[0].Name.Should().Contain("Brenda Tree");
                SearchResultsAttendeesList[0].Title.Should().Contain("Manager");
            }
        }

        [Test]
        [Category("Advanced")]
        public void Advanced_TODO()
        {
            // Arrange

            // Act
            homePageSteps.OpenPage();
            homePageSteps.ClickStartPractisingButton();
            basicExamplesSteps.ClickProceedNextButton();
            intermediateExamplesSteps.ClickProceedNextButton();
            advancedExamplesSteps.ClickTableDataSearchLink();

            // Assert
        }
    }
}