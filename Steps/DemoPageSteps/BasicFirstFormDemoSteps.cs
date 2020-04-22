using SeleniumFrameworkPractise.Pages;

namespace SeleniumFrameworkPractise.Steps
{
    public class BasicFirstFormSteps
    {
        private BasicFirstFormPage BasicFirstFormDemoPage;

        public BasicFirstFormSteps(BasicFirstFormPage basicFirstFormDemoPage)
        {
            this.BasicFirstFormDemoPage = basicFirstFormDemoPage;
        }

        public string EnterCharactersAndReturnDisplayedCharacters(string text)
        {
            BasicFirstFormDemoPage.InputMessage(text);
            BasicFirstFormDemoPage.ClickShowMessageButton();
            return BasicFirstFormDemoPage.GetYourMessageText();
        }

        public string EnterCharactersAndReturnDisplayedSumOfCharacters(string textA, string textB)
        {
            BasicFirstFormDemoPage.InputCharactersIntoInputA(textA);
            BasicFirstFormDemoPage.InputCharactersIntoInputB(textB);
            BasicFirstFormDemoPage.ClickGetTotalButton();
            return BasicFirstFormDemoPage.GetTotalOfInputsText();
        }
    }
}