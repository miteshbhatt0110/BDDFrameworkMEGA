# MEGABDDFramework

## Overview
The project contains Selenium automation code to test Buggy Cars Rating website. Selenium BDD framework with Page Object Model (using C#) has been used to automate the critical 
scenarios listed below - 
1. Verify that a sample file can be created on File manager screen
2. Verify that the sample file can be deleted
3. Verify that that sample file can be restored from Rubbish Bin
4. Verify that all the linux links (35) on drop down are downloadable - RestSharp has been used in conjuction with BDD to verify that all links are downloadable

## Prerequisites and packages to install
1. Install Visual Studio 2019
2. Dependencies that need to be installed on Visual Studio
   Use NuGet (Project > Manage NuGet packages) to install Specflow, Nunit and Selenium
3. $ git clone https://github.com/miteshbhatt0110/BDDFrameworkMEGA.git


## How to Run the tests
1. Once the project is cloned onto the local repository, tests can be run via Test Explorer on VS2019
2. Click on Test menu option -> Run
3. The screenshots are generated after each scenario is run and they are stored in the Documents folder on the local machine
4. The script uses data driven test for Login. To change the test data, go to the TestData folder in the project, and update ProfileData.csv - add your email id and password. 

