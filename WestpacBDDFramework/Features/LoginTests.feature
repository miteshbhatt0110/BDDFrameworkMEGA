Feature: Login Tests

Background:
	Given I navigate to Buggy Cars website

@LoginTests
Scenario Outline: Verify that user can successfully login when I enter valid credentials
	When I enter <Username>, <Password>
	And I click on Login
	Then I should see welcome message 'Hi, <User>' on top of the page

	Examples:
		| Username       | Password           | User   |
		| MiteshBi | mynameisMitesh@123 | Mitesh |

Scenario Outline: Verify that user cannot login with invalid credentials
	When I enter <Username>, <Password>
	And I click on Login
	Then I should see Invalid credentials message

	Examples:
		| Username | Password    |
		| MiteshBi | mynamei@123 |