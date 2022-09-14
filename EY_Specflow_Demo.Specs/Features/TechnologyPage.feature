Feature: TechnologyPage

#    TC-EY-09
@EY
Scenario: Open Technology page from Insights option
	Given user enters the url
	And Welcome popup window should be displayed
	When user clicks I accept all cookies button
	Then home page should be displayed without popup
	Given Insights option is available at nav bar
	And User clicks Insights option
	Then Trending Topics should be displayed
	And C-suite agendas should be displayed
	When User clicks Technology option
	Then Technology page should be loaded
	When User clicks Read more button
	Then More information should be displayed
	When User scrolls down to Our Latest Thinking article
	Then Our Latest Thinking article should be displayed
	And article title image box should be displayed
	When User clicks on the article image
	Then Article page should be loaded
	When User scrolls down the article page
	Then Show references icons should be displayed
	When User clicks on Facebook icon
	Then Facebook page should be loaded on new tab