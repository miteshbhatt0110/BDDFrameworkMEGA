Feature: Profile details test
Background:
	Given I navigate to Buggy Cars website

@LoginTests
Scenario Outline: Verify that user can Save profile details 
	When I enter <Username>, <Password>
	And I click on Login
	Then I should see welcome message 'Hi, <User>' on top of the page
	When I click Profile on the website navigation bar
	Then I should see Basic and Additional Info about my profile
	When I enter my profile details 
	And I click on Save
	Then I should see the profile save is successful message
	Examples:
		| Username | Password           | User   |
		| MiteshBi | mynameisMitesh@123 | Mitesh |