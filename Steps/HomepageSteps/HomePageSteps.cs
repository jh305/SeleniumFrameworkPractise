using SeleniumFrameworkPractise.Pages;

namespace SeleniumFrameworkPractise.Steps
{
    public class HomePageSteps
    {
        private Homepage _homepage;

        public HomePageSteps(Homepage homepage)
        {
            this._homepage = homepage;
        }

        public void OpenPage() =>
            _homepage.NavigateToPage();

        public void ClickStartPractisingButton() =>
            _homepage.ClickStartPractisingElement();
    }
}