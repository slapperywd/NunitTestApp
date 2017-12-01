Feature: SpecFlowFeature1
	 Simple test of specflow feature file

@trainTimetable
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@trainTimetable
Scenario: Add two numbers1
	Given I have entered 50 into the calculator1
	And I have entered 70 into the calculator1
	When I press add1
	Then the result should be 120 on the screen1
