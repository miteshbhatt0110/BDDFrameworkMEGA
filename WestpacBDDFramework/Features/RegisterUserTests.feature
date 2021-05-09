Feature: Registration of a User tests

Background:
	Given I navigate to Buggy Cars website

@RegistrationTests
Scenario Outline: Verify that user can successfully register on the Register page
	When I click on the Register button
	And I type registration details for the user <Username>, <FirstName>, <LastName>, <Password>, <ConfirmPassword>
	And I click on Register
	Then I should see Registration Successful message

	Examples:
		| Username  | FirstName | LastName | Password           | ConfirmPassword    |
		| MitCarUser | Mitesh    | Bhatt    | mynameisMitesh@123 | mynameisMitesh@123 |

Scenario Outline: Verify that user cannot register with same username
	When I click on the Register button
	And I type registration details for the user <Username>, <FirstName>, <LastName>, <Password>, <ConfirmPassword>
	And I click on Register
	Then I should see Username already exists message

	Examples:
		| Username  | FirstName | LastName | Password           | ConfirmPassword    |
		| MitCarUser | Mitesh    | Bhatt    | mynameisMitesh@123 | mynameisMitesh@123 |