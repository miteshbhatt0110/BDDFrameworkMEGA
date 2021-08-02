using OpenQA.Selenium;
using System.Collections.Generic;

namespace WestpacBDDFramework.Pages
{
    public class FileManagerPage : BasePage
    {
        private readonly By _fileManagerText = By.XPath("//span[contains(text(),'FILE MANAGER')]");
        private readonly By _cloudDrivePanel = By.XPath("//span[contains(text(),'Cloud Drive')]");
        private readonly By _createNewFolderButton = By.XPath("//button[@title='Create new folder']");
        private readonly By _createFileOption = By.XPath("//span[text()='New text file']");
        private readonly By _fileNameTextBox = By.XPath("//input[@name='dialog-new-file']");
        private readonly By _createButton = By.XPath("//button[contains(@class,'fm-dialog-new-file-button')]//span[text()='Create']");
        private readonly By _textEditorBars = By.ClassName("text-editor-bars");
        private readonly By _textEditor = By.XPath("//div[@class='CodeMirror-scroll']");
        private readonly By _saveButton = By.XPath("//span[text()='Save']");
        private readonly By _closeButton = By.ClassName("close-btn");
        private readonly By _newFileEntry = By.XPath("//td//span[contains(@class,'tranfer-filetype-txt')]");
        private readonly By _emptyCloudDrive = By.CssSelector(".fm-empty-section.fm-empty-cloud");
        private readonly By _removeOption = By.CssSelector(".dropdown-item.remove-item");
        private readonly By _restoreOption = By.CssSelector(".dropdown-item.revert-item");
        private readonly By _areYouSureBox = By.Id("msgDialog-title");
        private readonly By _yesButton = By.XPath("//span[text()='Yes']");
        private readonly By _rubbishBinButton = By.XPath("//button[contains(@class, 'rubbish-bin')]");
        private readonly By _rubbishBinPanel = By.XPath("//span[contains(text(),'Rubbish Bin')]");

        public FileManagerPage(IWebDriver driver) : base(driver)
        {
        }

        public List<By> GetFileManagerPageElements()
        {
            List<By> fileManagerPageElements = new List<By>
            {
                _fileManagerText,
                _createNewFolderButton,
            };
            return fileManagerPageElements;
        }

        public List<By> GetTextEditorElements()
        {
            List<By> textEditorElements = new List<By>
            {
                _textEditorBars,
                _textEditor,
            };
            return textEditorElements;
        }
        public void ClickCreateNewFolder()
        {
            ClickElement(_createNewFolderButton);
        }
        public void RightClickOnPage()
        {
            RightClick(_emptyCloudDrive);
        }

        public void ClickCreateNewFile()
        {
            ClickElement(_createFileOption);
        }

        public void EnterFileName(string text)
        {
            EnterText(_fileNameTextBox, text);
        }

        public void EnterSampleTextOnEditor(string text)
        {
            EnterText(_textEditor, text);
        }
        public void ClickCreateButton()
        {
            ClickElement(_createButton);
        }

        public void ClickSaveButton()
        {
            ClickElement(_saveButton);
        }

        public void ClickCloseButton()
        {
            ClickElement(_closeButton);
        }

        public void AssertFileName(string value)
        {
            AssertText(_newFileEntry, value);
        }

        public void RightClickOnFile()
        {
            RightClick(_newFileEntry);
        }

        public void ClickRemove()
        {
            ClickElement(_removeOption);
        }

        public void ClickRestore()
        {
            ClickElement(_restoreOption);
        }

        public void ClickYesButton()
        {
            ClickElement(_yesButton);
        }

        public void ClickRubbishBin()
        {
            ClickElement(_rubbishBinButton);
        }
    }
}
