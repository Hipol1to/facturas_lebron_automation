Feature: Validate-LogIn


@EncioEvent_TestCase

Scenario: Validate user can login using correct credentials
	Given user navigates to login web form
	When user types the correct credentials
	Then user should be in main screen
