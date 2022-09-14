Feature: ExploreCareerAtEYPage

#    TC-EY-18
  @EY
  Scenario: Explore Career at EY page from Career options
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    Given Career Option is visible in the nav bar
    And user clicks on Career option
    Then Career option wrapper should be visible
    And Explore button should be visible under Career section
    When User clicks on Explore button from Career section
    Then Career at EY page should be loaded
    When User scrolls down to Students section
    Then How to apply button should be displayed
    When User clicks on How to apply button
    Then How to apply page should be loaded
    And Hiring process for students should be displayed
    When User scrolls down to processes
    Then Process steps should be displayed
    When User clicks on step one
    Then Step details should be displayed