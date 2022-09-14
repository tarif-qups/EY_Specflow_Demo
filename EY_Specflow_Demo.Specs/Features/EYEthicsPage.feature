Feature: EYEthicsPage
    
#  TC-EY-07
  @EY
  Scenario: EY Ethics Page
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    When User scrolls down to the end
    Then Footer section should be visible
    And Site map link should be visible
    When User clicks on Site map link
    Then Site map page should be loaded
    And Legal section should be displayed
    And EY Ethics Hotline link should be displayed
    When User clicks on EY Ethics Hotline link
    Then EY Ethics Hotline page should be loaded
    And Code of conduct link should be visible
    When User clicks on Code of conduct link
    Then Global Code of conduct page should be loaded