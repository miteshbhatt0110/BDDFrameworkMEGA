using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WestpacBDDFramework.Pages;

namespace WestpacBDDFramework.StepDefinitions
{
    public class CreateNewFileSteps : BaseSteps
    {
        private readonly ScenarioContext _context;
        private FileManagerPage fileManagerPage;
        private string enteredName = "MyTestFile";

        public CreateNewFileSteps(IWebDriver driver, ScenarioContext context) : base(driver)
        {
            fileManagerPage = new FileManagerPage(driver);
            _context = context;
        }

        [When(@"I right click and click on New text file option")]
        public void WhenIRightClickAndClickOnNewTextFileOption()
        {
            fileManagerPage.RightClickOnPage();
            fileManagerPage.ClickCreateNewFile();

        }

        [When(@"I enter the file name and click on Create")]
        public void WhenIEnterTheFileNameAndClickOnCreate()
        {
            fileManagerPage.EnterFileName(enteredName);
            fileManagerPage.ClickCreateButton();
        }

        [Then(@"I should see the text editor")]
        public void ThenIShouldSeeTheTextEditor()
        {
            foreach (By field in fileManagerPage.GetTextEditorElements())
            {
                BasePage.WaitForElementToBeDisplayed(field, 5);
            }
        }

        [Then(@"The file should be created with the entered name")]
        public void ThenTheFileShouldBeCreatedWithTheEnteredNameAndText()
        {
            fileManagerPage.ClickCloseButton();
            fileManagerPage.AssertFileName(enteredName+ ".txt");
        }

        [When(@"I right click on the text file")]
        public void WhenIRightClickOnTheTextFile()
        {

            fileManagerPage.RightClickOnFile();
        }

        [When(@"I click on remove")]
        public void WhenIClickOnRemove()
        {
            fileManagerPage.ClickRemove();
        }

        [When(@"I click on Yes")]
        public void WhenIClickOnYes()
        {
            fileManagerPage.ClickYesButton();
        }

        [Then(@"the sample file should be deleted")]
        public void ThenTheSampleFileShouldBeDeleted()
        {
            foreach (By field in fileManagerPage.GetFileManagerPageElements())
            {
                BasePage.WaitForElementToBeDisplayed(field, 5);
            }
        }

        [When(@"I go to Rubbish Bin")]
        public void WhenIGoToRubbishBin()
        {
            fileManagerPage.ClickRubbishBin();
        }

        [When(@"I click on Restore")]
        public void WhenIClickOnRestore()
        {
            fileManagerPage.ClickRestore();
        }

        [Then(@"the sample file should be restored")]
        public void ThenTheSampleFileShouldBeRestored()
        {
            fileManagerPage.AssertFileName(enteredName + ".txt");
        }


    }
}
