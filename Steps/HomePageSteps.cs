using SeleniumFrameworkPractise.Pages;

namespace SeleniumFrameworkPractise.Steps
{
    public class HomePageSteps
    {
        private HomePage Homepage;

        public HomePageSteps(HomePage homepage)
        {
            this.Homepage = homepage;
        }

        public void OpenPage() =>
            Homepage.NavigateToPage();

        public void ClickStartPractisingButton() =>
            Homepage.ClickStartPractisingElement();
    }
}