Feature: Create, Delete and Restore File
	To validate creation, deletion and restoration of sample file

Background:
	Given I navigate to mega website
	And I enter my user credentials and login
	Then I should be navigated to the File Manager page

Scenario: 01 Verify that a sample file can be created on File manager screen
	When I right click and click on New text file option
	And I enter the file name and click on Create
	Then I should see the text editor 
	And The file should be created with the entered name

Scenario: 02 Verify that the sample file can be deleted
	When I right click on the text file
	And I click on remove
	When I click on Yes
	Then the sample file should be deleted 

Scenario: 03 Verify that that sample file can be restored from Rubbish Bin
	When I go to Rubbish Bin
	And I right click on the text file
	And I click on Restore
	Then the sample file should be restored