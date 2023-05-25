Feature: Dark Mode/ Light Mode is able to be toggled

A short summary of the feature

@Jazz
Scenario: Visitor can toggle Dark Mode
	Given I am a visitor on the Home Page
	When they click the dark mode toggler
	Then the background image should change and the colors should change
