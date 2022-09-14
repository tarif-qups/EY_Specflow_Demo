Feature: LocationsPage

#  TC-EY-05
  @EY
  Scenario: Locations Page
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    When User scrolls down to the end
    Then Footer section should be visible
    And Our locations link should be visible
    When User clicks on our locations link
    Then Locations page should be loaded
    And Location search field should be visible
    When User enters "California" in the location search field
    Then Location suggest list should be displayed
    When User clicks on California from the list
    Then California location page should be loaded
    And Irvine location box should be displayed
    When User clicks on California
    Then Location details should be hidden