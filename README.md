# WestpacBDDFramework

## Overview
The sample project contains Selenium automation code to test Buggy Cars Rating website. Selenium BDD framework with Page Object Model has been used to automate the critical 
scenarios listed below - 
1. Login Tests - Verify Valid and Invalid credentials
2. User Registration Tests - Verify registration of a new user and registration of a user that already exists
3. Update User Profile - Verify user can update Profile
4. Comment and Vote - Verify user can Vote and Comment on a Car

### Prerequisites
1. Install Visual Studio 2019
2. Dependencies that need to be installed on Visual Studio
   Use NuGet (Project > Manage NuGet packages) to install Specflow, Nunit and Selenium
3. $ git clone https://github.com/miteshbhatt0110/WestpacBDDFramework.git

## How to Run the tests
1. Once the project is cloned onto the local repository, tests can be run via Test Explorer on VS2019
2. Click on Test menu option -> Run
3. The screenshots are generated after each scenario is run and they are stored in the Documents folder on the local machine
4. The script uses data driven test for updating User Profile. To change the test data, go to the TestData folder in the project, and update ProfileData.csv 
5. To run the Registration successful test multiple times, the Username on the feature file would need to be changed - This is because only unique usernames are allowed to be registered

## Test document contains the details about the Testing approach and Bug report

