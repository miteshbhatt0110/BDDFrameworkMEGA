Feature: CheckDownloadableLinks
	To valid linux links are downloadable

@DownloadLinks
Scenario: Verify that all the linux links on drop down are downloadable
	Given I navigate mega sync webpage
	When I click on Linux option at the bottom of the page
	Then I should be able to download all the linux options