Feature: Calculator
	In order to perform a sustainbility weight calculation
	As a user
	I want to use the web browser page in the calculator section

Scenario: Calculate sustainibility weight of petrol, for 2 days, doing 100 miles
	Given the user has entered 2 into the days cell
	And the user has entered 100 into the distance cell
	And the user has selected miles into the distance measurement cell
	And the user has selected petrol into the transport mode cell
	When the user clicks on calculate
	Then the result should be 3200 on the screen