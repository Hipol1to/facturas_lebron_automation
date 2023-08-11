Feature: Validate-Last-events


@EncioEvent_TestCase

Scenario: Validate last events are being displayed
	Given user log in with valid credentials
	And user is on main screen
	When look for last events section
	Then last events section should be visible
	And shoul have event photo and description
