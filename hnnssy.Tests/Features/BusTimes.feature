Feature: BusTimes
	In order to avoid being late in the morning
	As a user
	I want to be told the bus times for the closest available bus stops

@Bus_Times
Scenario: The Bus Times page is loaded
	Given The current time and date
	When I load the bus times page
	Then the closest bus time for the library stop is displayed
