using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WestpacBDDFramework.Pages
{
    public class DiabloCommentsPage : BasePage
    {
        // Elements in the Diablo car page

        private readonly By _diabloImage = By.XPath("//img[@src='/img/cars/Diablo.jpg']");
        private readonly By _diabloDescription = By.XPath("//div//p[contains(text(),'This last')]");
        private readonly By _listOfComments = By.XPath("//table[@class='table']");
        private readonly By _commentTextbox = By.Id("comment");
        private readonly By _voteButton = By.CssSelector(".btn.btn-success");
        public DiabloCommentsPage(IWebDriver driver) : base(driver)
        {
        }
        public void DiabloIsDisplayed()
        {
            WaitForElementToBeDisplayed(_diabloImage, 5);
            WaitForElementToBeDisplayed(_diabloDescription, 5);
            WaitForElementToBeDisplayed(_listOfComments, 5);
            WaitForElementToBeDisplayed(_commentTextbox, 5);
            WaitForElementToBeDisplayed(_voteButton, 5);
        }
        public By GetDiabloDescription(string carName)
        {
            By carDescription = By.XPath($"//div[@class='row']//p//strong[text()='{carName}']");
            return carDescription;
        }
        public void EnterDiabloComments(string comment)
        {
            EnterText(_commentTextbox, comment);
        }
        public void ClickVoteButton()
        {
            ClickElement(_voteButton);
        }
        public void GetEnteredComment(string comment)
        {
            By carDescription = By.XPath($"//td[contains(text(),'{comment}')]");
            AssertText(carDescription, comment);
        }
    }
}
