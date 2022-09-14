Feature: SupportingOrgPage

    
#  TC-EY-04
  @EY
  Scenario: Supporting organizations Page
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    When User scrolls down to supporting organizations section
    Then Supporting organizations slider should displayed
    When User clicks on first slider
    Then Selected topic page should be loaded