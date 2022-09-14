Feature: WebcastsPage

#  TC-EY-06
  @EY
  Scenario: Webcasts Page
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    When User scrolls down to the end
    Then Footer section should be visible
    And Webcasts link should be visible
    When User clicks on webcasts link
    Then Webcasts page should be loaded
    And Webcasts list should be displayed
    When User clicks on details button for first webcast
    Then Webcasts details page should be loaded
    And Register button should be displayed
    When User clicks on Register button
    Then Register for form should be displayed