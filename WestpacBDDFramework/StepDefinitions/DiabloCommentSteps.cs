using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WestpacBDDFramework.Pages;

namespace WestpacBDDFramework.StepDefinitions
{
    [Binding]
    public class DiabloCommentSteps : BaseSteps
    {
        private readonly ScenarioContext _context;
        private CarsPage carsPage;
        private LamborghiniListPage lamborghiniListPage;
        private DiabloCommentsPage diabloCommentsPage;
        private string enteredComment = "My car comment";

        public DiabloCommentSteps(IWebDriver driver, ScenarioContext context) : base(driver)
        {
            carsPage = new CarsPage(driver);
            lamborghiniListPage = new LamborghiniListPage(driver);
            diabloCommentsPage = new DiabloCommentsPage(driver);
            _context = context;
        }
        [Then(@"I should see Popular cars on the page")]
        public void ThenIShouldSeePopularCarsOnThePage()
        {
            carsPage.CarsAreVisible();
        }

        [When(@"I click on Popular Make section")]
        public void WhenIClickOnPopularMakeSection()
        {
            carsPage.ClickPopularMake();
        }

        [Then(@"I should see the Lamborghini description and list of Models")]
        public void ThenIShouldSeeTheLamborghiniDescriptionAndListOfModels()
        {
            foreach (By field in lamborghiniListPage.GetLaborghiniPageElements())
            {
                BasePage.WaitForElementToBeDisplayed(field, 5);
            }
        }

        [When(@"I click on Diablo link")]
        public void WhenIClickOnDiabloLink()
        {
            lamborghiniListPage.ClickCarName("Diablo");
        }

        [Then(@"I should see the car description, specification and comments")]
        public void ThenIShouldSeeTheCarDescriptionSpecificationAndComments()
        {
            diabloCommentsPage.DiabloIsDisplayed();
            diabloCommentsPage.GetDiabloDescription("Diablo");
        }
        [When(@"I type enter comments and click on Vote")]
        public void WhenITypeEnterCommentsAndClickOnVote()
        {
            diabloCommentsPage.EnterDiabloComments(enteredComment);
            diabloCommentsPage.ClickVoteButton();
        }

        [Then(@"I should see my comment in the table below")]
        public void ThenIShouldSeeMyCommentInTheTableBelow()
        {
            diabloCommentsPage.GetEnteredComment(enteredComment);
        }
    }

}

