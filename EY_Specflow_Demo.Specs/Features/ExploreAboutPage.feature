Feature: ExploreAboutPage

#    TC-EY-19
  @EY
  Scenario: Explore about page
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    Given About option is available in the nav bar
    And User clicks About option
    Then About wrapper should be visible
    And Contact with us option should be visible
    When user clicks on Contact with us option
    Then Contact form should be loaded