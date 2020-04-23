using SeleniumFrameworkPractise.Pages;

namespace SeleniumFrameworkPractise.Steps
{
    public class HomePageSteps
    {
        private Homepage Homepage;

        public HomePageSteps(Homepage homepage)
        {
            this.Homepage = homepage;
        }

        public void OpenPage() =>
            Homepage.NavigateToPage();

        public void ClickStartPractisingButton() =>
            Homepage.ClickStartPractisingElement();
    }
}