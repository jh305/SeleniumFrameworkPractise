using SeleniumFrameworkPractise.Pages;

namespace SeleniumFrameworkPractise.Steps
{
    public class BasicFirstFormSteps
    {
        private BasicFirstFormPage _basicFirstFormDemoPage;

        public BasicFirstFormSteps(BasicFirstFormPage basicFirstFormDemoPage)
        {
            this._basicFirstFormDemoPage = basicFirstFormDemoPage;
        }

        public string EnterCharactersAndReturnDisplayedCharacters(string text)
        {
            _basicFirstFormDemoPage.InputMessage(text);
            _basicFirstFormDemoPage.ClickShowMessageButton();
            return _basicFirstFormDemoPage.GetYourMessageText();
        }

        public string EnterCharactersAndReturnDisplayedSumOfCharacters(string textA, string textB)
        {
            _basicFirstFormDemoPage.InputCharactersIntoInputA(textA);
            _basicFirstFormDemoPage.InputCharactersIntoInputB(textB);
            _basicFirstFormDemoPage.ClickGetTotalButton();
            return _basicFirstFormDemoPage.GetTotalOfInputsText();
        }
    }
}