Feature: ExploreServicesPage
    
#    TC-EY-14
  @EY
  Scenario: explore services page from services options
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    Given Services option is visible in the nav bar
    And User clicks Services option
    Then Services wrapper should be displayed
    And Explore button should be visible under Services section
    When User clicks on Explore button from Services section
    Then Services page should be loaded
    When User scrolls down to Our alliances label
    Then Our alliances section should be displayed
    And Find out more button should be visible
    When User clicks on Find out more button
    Then Alliances page should be loaded