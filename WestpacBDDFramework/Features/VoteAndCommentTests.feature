Feature: VoteAndCommentTests

Background:
	Given I navigate to Buggy Cars website

@VoteAndCommentTests
Scenario Outline: Verify that user can vote for a car and comments can be seen on the voting page
	When I enter <Username>, <Password>
	And I click on Login
	Then I should see Popular cars on the page
	When I click on Popular Make section 
	Then I should see the Lamborghini description and list of Models
	When I click on Diablo link
	Then I should see the car description, specification and comments
	When I type enter comments and click on Vote
	Then I should see my comment in the table below
	Examples:
		| Username | Password           | 
		| MitCarUser | mynameisMitesh@123 |