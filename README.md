# WestpacBDDFramework

## Overview
The project contains Selenium automation code to test Buggy Cars Rating website. Selenium BDD framework with Page Object Model (using C#) has been used to automate the critical 
scenarios listed below - 
1. Login Tests - Verify Valid and Invalid credentials
2. User Registration Tests - Verify registration of a new user and registration of a user that already exists
3. Update User Profile - Verify user can update Profile
4. Comment and Vote - Verify user can Vote and Comment on a Car

## Prerequisites and packages to install
1. Install Visual Studio 2019
2. Dependencies that need to be installed on Visual Studio
   Use NuGet (Project > Manage NuGet packages) to install Specflow, Nunit and Selenium
3. $ git clone https://github.com/miteshbhatt0110/WestpacBDDFramework.git
4. Open the .csproj file on Visual Studio and add the below dependencies:
<ItemGroup>
		<PackageReference Include="DotNetSeleniumExtras.WaitHelpers" Version="3.11.0" />
		<PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.9.4" />
		<PackageReference Include="Noksa.WebDriver.ScreenshotsExtensions" Version="0.1.5.3" />
		<PackageReference Include="NUnit" Version="3.13.0" />
		<PackageReference Include="NUnit3TestAdapter" Version="3.13.0" />
		<PackageReference Include="Selenium.WebDriver" Version="3.141.0" />
		<PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="90.0.4430.2400" />
		<PackageReference Include="Selenium.WebDriver.GeckoDriver" Version="0.29.1" />
		<PackageReference Include="SpecFlow" Version="3.7.38" />
		<PackageReference Include="SpecFlow.NUnit" Version="3.7.38" />
		<PackageReference Include="System.Configuration.ConfigurationManager" Version="5.0.0" />
</ItemGroup>

## How to Run the tests
1. Once the project is cloned onto the local repository, tests can be run via Test Explorer on VS2019
2. Click on Test menu option -> Run
3. The screenshots are generated after each scenario is run and they are stored in the Documents folder on the local machine
4. The script uses data driven test for updating User Profile. To change the test data, go to the TestData folder in the project, and update ProfileData.csv 
5. To run the Registration successful test multiple times, the Username on the feature file would need to be changed - This is because only unique usernames are allowed to be registered

## Testing approach and Bug report
1. Test Document.docx has been attached to the repo that contains the Testing approach and Bug report

