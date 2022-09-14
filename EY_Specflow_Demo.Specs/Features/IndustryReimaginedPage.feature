Feature: IndustryReimaginedPage

#    TC-EY-16
  @EY
  Scenario: Explore Industry reimagined page from Industries option
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    Given Industries option is visible in the nav bar
    And User clicks Industries option
    Then Industries wrapper should be visible
    And Explore button should be visible under Industry section
    When User clicks on Explore button from Industry section
    Then Industry reimagined page should be loaded
    When User clicks Read more button
    Then More information should be displayed
    When User scrolls down to Related industry section
    Then Related industry section should be displayed
    And Automotive option should be displayed
    When User clicks Automotive option
    Then Automotive page should be loaded