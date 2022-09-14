Feature: ExploreStrategyOption

#  TC-EY-12
  @EY
  Scenario: explore Strategy by EY-Parthenon option from services options
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    Given Services option is visible in the nav bar
    And User clicks Services option
    Then Services wrapper should be displayed
    And Spotlight should be displayed
    When user clicks on Strategy by EY-Parthenon option
    Then Strategy by EY-Parthenon list should be displayed
    When user clicks on Corporate and growth option
    Then Corporate and growth strategy page should be loaded
    When user scrolls down the growth strategy page
    Then How EY-Parthenon can help section should be displayed
    And How Digital strategy consulting section should be displayed
    When user clicks on Digital strategy consulting link
    Then Digital strategy consulting page should be loaded
    When user scrolls down the Digital strategy consulting page
    And user clicks on digital strategy consulting growth plus icon
    Then digital strategy consulting growth details should be displayed
    When user scrolls down to consulting team section
    And user clicks show more button
    Then more team members should be displayed