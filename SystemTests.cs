using NUnit.Framework;
using SeleniumFrameworkPractise.Pages;
using SeleniumFrameworkPractise.Steps;

namespace SeleniumFrameworkPractise
{
    [TestFixture]
    public class SystemTests : DriverBase
    {
        [Test]
        public void test01()
        {
            var HomePageSteps = new HomePageSteps(new HomePage(Driver));

            HomePageSteps.OpenPage();
        }
    }
}