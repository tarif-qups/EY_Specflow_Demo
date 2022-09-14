Feature: TransformationPage

#    TC-EY-10
@EY
Scenario: Open Transformation page from Insights option
	Given user enters the url
	And Welcome popup window should be displayed
	When user clicks I accept all cookies button
	Then home page should be displayed without popup
	Given Insights option is available at nav bar
	And User clicks Insights option
	Then Insights wrapper should be displayed
	And Transformation option should be displayed
	When User clicks on Transformation option
	Then Transformation page should be loaded
	When User scrolls down to CEO agenda section
	Then CEO agenda section should be displayed
	And Discover more button should be displayed
	When User clicks on Discover more button
	Then CEO agenda page should be loaded