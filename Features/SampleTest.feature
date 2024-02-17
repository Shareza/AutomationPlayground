Feature: SampleTest

	This sample feature file has a sample test using Playwright and SpecFlow.

Scenario: 1 - User should be able to navigate to home page
	When User navigates to home page
	Then Test quote should be visible
	And Test quote should read 'Quality is not an act, it is a habit.'

