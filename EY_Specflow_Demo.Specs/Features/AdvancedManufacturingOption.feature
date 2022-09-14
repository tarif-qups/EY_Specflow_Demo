Feature: AdvancedManufacturingOption

#  TC-EY-15
  @EY
  Scenario: Explore Advanced Manufacturing option from Industries option
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    Given Industries option is visible in the nav bar
    And User clicks Industries option
    Then Industries wrapper should be visible
    And Case Studies text should be visible
    And Advanced Manufacturing option should be visible
    When user clicks Advanced Manufacturing option
    Then Advanced manufacturing page should be loaded
    When User clicks Read more button
    Then More information should be displayed
    When User scrolls down to Our Latest Thinking article
    Then Our Latest Thinking article should be displayed
    And Article on Electric vehicle should be visible
    When User clicks on the Article on Electric vehicle
    Then Article on Electric vehicle page should be loaded
    When User scrolls down to twitter icon
    And clicks Twitter icon
    Then Twitter page should be loaded on new tab