Feature: LongTermValuePage

#    TC-EY-11
@EY
Scenario: Open Long-term value page from Insights option
	Given user enters the url
	And Welcome popup window should be displayed
	When user clicks I accept all cookies button
	Then home page should be displayed without popup
	Given Insights option is available at nav bar
	And User clicks Insights option
	Then Insights wrapper should be displayed
	And Long-term value option should be displayed
	When User clicks on Long-term value option
	Then Long-term value page should be loaded
	When User scrolls down to EY value section
	Then EY value Realized section should be displayed
	And Explore button should be displayed
	When User clicks Explore button
	Then EY Value Realized page should be loaded
	When User scrolls down to Show resources section
	Then Show resources section should be displayed
	When User clicks on show resources
	Then Report download option should be visible